﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKy_DTO
    {
        private string maTK;
        private string tenTK;
        private string matKhau;
        private string maQuyen;

        public DangKy_DTO()
        {

        }
        public DangKy_DTO(string maTK, string tenTK, string matKhau, string maQuyen)
        {
            MaTK = maTK;
            TenTK = tenTK;
            MatKhau = matKhau;
            MaQuyen = maQuyen;
        }

        public string MaTK { get => maTK; set => maTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
    }
}
