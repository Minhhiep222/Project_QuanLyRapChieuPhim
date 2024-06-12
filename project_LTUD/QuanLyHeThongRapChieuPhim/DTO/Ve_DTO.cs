using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ve_DTO
    {
        private string maVe;
        private string maShow;
        private string maPhim;
        private string giaVe;
        private string maHD;
        private string ghe;
        public Ve_DTO()
        {

        }

        public Ve_DTO(string maVe, string maShow, string maPhim, string giaVe, string maHD, string ghe)
        {
            MaVe = maVe;
            MaShow = maShow;
            MaPhim = maPhim;
            GiaVe = giaVe;
            MaHD = maHD;
            Ghe = ghe;
        }

        public string MaVe { get => maVe; set => maVe = value; }
        public string MaShow { get => maShow; set => maShow = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string GiaVe { get => giaVe; set => giaVe = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string Ghe { get => ghe; set => ghe = value; }
    }
}
