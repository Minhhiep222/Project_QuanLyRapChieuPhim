using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string maHD;
        private string maRap;
        private string maNV;
        private string maKH;

        public HoaDon_DTO() { } 
        public HoaDon_DTO(string maHD, string maRap, string maNV, string maKH)
        {
            this.MaHD = maHD;
            this.MaRap = maRap;
            this.MaNV = maNV;
            this.MaKH = maKH;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaRap { get => maRap; set => maRap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}
