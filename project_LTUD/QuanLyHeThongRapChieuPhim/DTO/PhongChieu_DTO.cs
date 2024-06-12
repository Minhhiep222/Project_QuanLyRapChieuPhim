using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieu_DTO
    {
        private string maPhong;
        private string maRap;
        private string tenPhong;
        private string tongSoGhe;

        public PhongChieu_DTO()
        {

        }
        public PhongChieu_DTO(string maPhong, string maRap, string tenPhong, string tongSoGhe)
        {
            this.MaPhong = maPhong;
            this.MaRap = maRap;
            this.TenPhong = tenPhong;
            this.TongSoGhe = tongSoGhe;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaRap { get => maRap; set => maRap = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string TongSoGhe { get => tongSoGhe; set => tongSoGhe = value; }
    }
}
