﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLopHoc.DTO
{
    public class FileBaiTap
    {
        private string mabaitap;
        private string id_file;
        private string path;
        private int lafiledapan;
        public FileBaiTap() { }
        public FileBaiTap(string mabaitap, string id_file, string tenfile, int lafiledapan)
        {
            this.mabaitap = mabaitap;
            this.id_file = id_file;
            this.path = tenfile;
            this.lafiledapan = lafiledapan;
        }

        public string Mabaitap { get => mabaitap; set => mabaitap = value; }
        public string Id_file { get => id_file; set => id_file = value; }
        public string Path { get => path; set => path = value; }
        public int Lafiledapan { get => lafiledapan; set => lafiledapan = value; }
    }
}
