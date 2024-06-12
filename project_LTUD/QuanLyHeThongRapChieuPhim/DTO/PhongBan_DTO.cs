using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan_DTO
    {
        private string maPhongBan;
        private string maRap;
        private string truongPhong;

        public PhongBan_DTO()
        {

        }
        public PhongBan_DTO(string maPhongBan, string maRap, string truongPhong)
        {
            this.MaPhongBan = maPhongBan;
            this.MaRap = maRap;
            this.TruongPhong = truongPhong;
        }

        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string MaRap { get => maRap; set => maRap = value; }
        public string TruongPhong { get => truongPhong; set => truongPhong = value; }
    }
}
