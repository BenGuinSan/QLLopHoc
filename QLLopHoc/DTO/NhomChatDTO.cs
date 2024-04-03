using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLopHoc.DTO
{
    public class NhomChatDTO
    {
        private string manhomchat;
        private string malop;
        private string ten;

        public NhomChatDTO(string manhomchat = "", string ten = "", string malop = "")
        {
            this.manhomchat = manhomchat;
            this.ten = ten;
            this.malop = malop;
        }

        public string Manhomchat { get => manhomchat; set => manhomchat = value; }
        public string Tennhomchat { get => ten; set => ten = value; }
        public string Malop { get => malop; set => malop = value; }
    }
}
