using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Quyen
    {
        //verible
        private string maQuyen;
        private string tenQuyen;

        public Quyen()
        {

        }
        public Quyen(string maQuyen, string tenQuyen)
        {
            this.maQuyen = maQuyen;
            this.tenQuyen = tenQuyen;
        }

        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }
    }
}
