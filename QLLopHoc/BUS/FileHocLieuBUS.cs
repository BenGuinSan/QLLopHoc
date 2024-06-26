﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Home.HomeComponents;

namespace QLLopHoc.BUS
{
    public class FileHocLieuBUS
    {
        private ArrayList list;
        List<string> file_local = new List<string>();
        List<FileHocLieu> list_filehl = new List<FileHocLieu>();
        FileHocLieuDAO filehlDAO;
        HocLieuDAO hoclieuDAO = new HocLieuDAO();

        public FileHocLieuBUS()
        {
            filehlDAO = new FileHocLieuDAO();
            loadList();
        }

        public void loadList()
        {
            list = filehlDAO.loadList();

        }
        public void get_local_file_in_panel(Panel panel)
        {
            file_local.Clear();
            foreach (Control control in panel.Controls)
            {
                // Check if the control is of type filetemp
                if (control is filetmp)
                {
                    //lay tat ca dia chi cua file
                    file_local.Add(((filetmp)control).FileName);
                }
            }
        }

        public Panel insert_file(Panel panel, string mahoclieu, int tinhtrang)
        {
            panel.Controls.Clear();
            List<FileHocLieu> list_filehl_temp = filehlDAO.get_list_filehoclieu(mahoclieu);
            foreach (FileHocLieu fileHocLieu in list_filehl_temp)
            {
                fileshow fileshow = new fileshow(fileHocLieu, tinhtrang);
                panel.Controls.Add(fileshow);
            }
            return panel;
        }

        public HocLieuDTO insert_hoclieu_and_filehoclieu(Panel panel, string machuong, string ten, string noidung, DriveService service)
        {
            get_local_file_in_panel(panel);
            list_filehl.Clear();
            foreach (string temp in file_local)
            {
                // Tạo yêu cầu tải lên tệp lên Google Drive và chỉ định thư mục đích bằng ID.
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Path.GetFileName(temp),
                    Parents = new List<string> { "1DOvh4D8ow_qophJAWEcInfSZrgkeIgvu" } // Thay "ID_cua_thu_muc_dich" bằng ID thư mục cụ thể.
                };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(temp, FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                    request.Upload();
                }

                var file = request.ResponseBody;
                FileHocLieu fileHocLieu = new FileHocLieu("123", Path.GetFileName(temp), file.Id);
                list_filehl.Add(fileHocLieu);
                if (file != null)
                {

                    //MessageBox.Show($"Tải lên thành công. ID của tệp: "+fileHocLieu.ToString());
                }
                else
                {
                    MessageBox.Show("Không thể tải lên tệp lên Google Drive.");
                }
            }
            return hoclieuDAO.taohoclieu(machuong, ten, noidung, list_filehl);
        }

        public void change_hoclieu_filehoclieu(Panel panel, string mahoclieu, string machuong, string ten, string noidung, DriveService service)
        {
            filehlDAO.drop_date_filehoclieu_mahoclieu(mahoclieu);
            HocLieuDTO hoclieu = new HocLieuDTO(mahoclieu, ten, noidung, machuong, 0);
            hoclieuDAO.update_hoclieu(hoclieu);
            foreach (Control control in panel.Controls)
            {
                if (control is fileshow userShowControl)
                {
                    FileHocLieu fileHocLieu = userShowControl.filehl;
                    filehlDAO.insert_filehoclieu(fileHocLieu);
                    //MessageBox.Show(fileHocLieu.ToString());
                }
                else if (control is filetmp userTempControl)
                {


                    // Lấy và sử dụng giá trị của thuộc tính filePath
                    string filePath = userTempControl.filePath;

                    // Tạo yêu cầu tải lên tệp lên Google Drive và chỉ định thư mục đích bằng ID.
                    var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                    {
                        Name = Path.GetFileName(filePath),
                        Parents = new List<string> { "1DOvh4D8ow_qophJAWEcInfSZrgkeIgvu" } // Thay "ID_cua_thu_muc_dich" bằng ID thư mục cụ thể.
                    };

                    FilesResource.CreateMediaUpload request;
                    using (var stream = new FileStream(filePath, FileMode.Open))
                    {
                        request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                        request.Upload();
                    }

                    var file = request.ResponseBody;
                    FileHocLieu fileHocLieu = new FileHocLieu(mahoclieu, Path.GetFileName(filePath), file.Id);
                    filehlDAO.insert_filehoclieu(fileHocLieu);
                    if (file != null)
                    {

                        //MessageBox.Show($"Tải lên thành công. ID của tệp: "+fileHocLieu.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không thể tải lên tệp lên Google Drive.");
                    }
                }
            }
        }
    }
}
