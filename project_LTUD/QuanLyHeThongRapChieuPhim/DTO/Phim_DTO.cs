using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phim_DTO
    {
        private string maPhim;
        private string tenPhim;
        private string theLoai;
        private string hangSX;
        public Phim_DTO()
        {

        }

        public Phim_DTO(string maPhim, string tenPhim, string theLoai, string hangSX)
        {
            MaPhim = maPhim;
            TenPhim = tenPhim;
            TheLoai = theLoai;
            HangSX = hangSX;
        }

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string HangSX { get => hangSX; set => hangSX = value; }
    }
    
}
