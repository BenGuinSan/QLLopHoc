﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;

namespace QLLopHoc.DTO
{
    public class TaiKhoanDTO : IComparable
    {
        private string mataikhoan;
        private int manhomquyen;
        private string hoten;
        private string email;
        private string matkhau;
        private string sodienthoai;
        private string anhdaidien;
        private int daxoa;

        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Email { get => email; set => email = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Anhdaidien { get => anhdaidien; set => anhdaidien = value; }
        public int Manhomquyen { get => manhomquyen; set => manhomquyen = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string mataikhoan, string hoten, string email, string matkhau, string sodienthoai, string anhdaidien, int manhomquyen, int daxoa)
        {
            this.mataikhoan = mataikhoan;
            this.hoten = hoten;
            this.email = email;
            this.matkhau = matkhau;
            this.sodienthoai = sodienthoai;
            this.anhdaidien = anhdaidien;
            this.manhomquyen = manhomquyen;
            this.daxoa = daxoa;
        }

        public override string ToString()
        {
            return $"Mã tài khoản: {mataikhoan}\n" +
               $"Mã nhóm quyền: {manhomquyen}\n" +
               $"Họ tên: {hoten}\n" +
               $"Email: {email}\n" +
               $"Mật khẩu: {matkhau}\n" +
               $"Số điện thoại: {sodienthoai}\n" +
               $"Ảnh đại diện: {anhdaidien}\n" +
               $"Đã xóa: {daxoa}";
        }

        public int CompareTo(Object obj)
        {
            TaiKhoanDTO taikhoan = (TaiKhoanDTO)obj;
            return this.mataikhoan.CompareTo(taikhoan.mataikhoan);
        }

        public int CompareTo(TaiKhoanDTO c1, TaiKhoanComparer.ComparisonType type)
        {
            switch (type)
            {
                case TaiKhoanComparer.ComparisonType.mataikhoan:
                    return this.mataikhoan.CompareTo(c1.mataikhoan);
                case TaiKhoanComparer.ComparisonType.manhomquyen:
                    return this.manhomquyen.CompareTo(c1.manhomquyen);
            }
            return 0;
        }

       
    }
}
