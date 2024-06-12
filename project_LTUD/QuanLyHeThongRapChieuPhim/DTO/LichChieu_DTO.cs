using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieu_DTO
    {
        private string maShow;
        private string maPhim;
        private string maPhong;
        private DateTime ngayChieu;
        private DateTime gioChieu;

        public LichChieu_DTO()
        {

        }
        public LichChieu_DTO(string maShow, string maPhim, string maPhong, DateTime ngayChieu, DateTime gioChieu)
        {
            MaShow = maShow;
            MaPhim = maPhim;
            MaPhong = maPhong;
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
        }

        public string MaShow { get => maShow; set => maShow = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayChieu { get => ngayChieu; set => ngayChieu = value; }
        public DateTime GioChieu { get => gioChieu; set => gioChieu = value; }
    }
}
