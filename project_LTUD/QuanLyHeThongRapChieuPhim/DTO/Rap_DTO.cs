using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Rap_DTO
    {
        private string maRap;
        private string tenRap;
        private string diaChi;
        private string sdt;
        public Rap_DTO()
        {

        }
        public Rap_DTO(string maRap, string tenRap, string diaChi, string sdt)
        {
            MaRap = maRap;
            TenRap = tenRap;
            DiaChi = diaChi;
            Sdt = sdt;
        }

        public string MaRap { get => maRap; set => maRap = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
