using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLyNV_CodeFirst.Models
{
    public class QLNV_Context :DbContext
    {
        public QLNV_Context():base("name=QLNhanVienConnect")
        {
            
        }

        public DbSet<NhanVien> NhanViens { get; set; }
    }
}