using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string maKH;
        private string tenKH;
        private string diachi;
        private string gioiTinh;
        private string sDT;
        private DateTime ngaysinh;

        public KhachHang_DTO()
        {

        }

        public KhachHang_DTO(string maKH, string tenKH, string diachi, string gioiTinh, string sDT, DateTime ngaysinh)
        {
            MaKH = maKH;
            TenKH = tenKH;
            Diachi = diachi;
            GioiTinh = gioiTinh;
            SDT = sDT;
            Ngaysinh = ngaysinh;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    }
}
