using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string maNV;
        private string cCCD;
        private string hoNV;
        private string tennv;
        private string diachi;
        private string maPhong;
        private string luong;
        private string gioiTinh;
        private string sDT;
        private DateTime ngaysinh;

        public NhanVien_DTO()
        {

        }
        public NhanVien_DTO(string maNV, string cCCD, string hoNV, string tennv, string diachi, string maPhong, string luong, string gioiTinh, string sDT, DateTime ngaysinh)
        {
            this.MaNV = maNV;
            this.CCCD = cCCD;
            this.HoNV = hoNV;
            this.Tennv = tennv;
            this.Diachi = diachi;
            this.MaPhong = maPhong;
            this.Luong = luong;
            this.GioiTinh = gioiTinh;
            this.SDT = sDT;
            this.Ngaysinh = ngaysinh;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string Luong { get => luong; set => luong = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    }
}
