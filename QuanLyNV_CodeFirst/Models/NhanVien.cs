using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNV_CodeFirst.Models
{
 
    [Table("NHAN_VIEN")]
    public class NhanVien
    {
        [Key]

        [Column(TypeName = "VARCHAR")]

        [StringLength(10)]

        public string MaNV { get; set; }

        [Column(TypeName = "NVARCHAR")]

        [StringLength(30)]

        public string HoTen { get; set; }

        public int GioiTinh { get; set; }

        [DataType(DataType.Date)]

        public DateTime NgaySinh { get; set; }

        [Column(TypeName = "VARCHAR")]

        [StringLength(20)]

        public string DienThoai { get; set; }

        [Column(TypeName = "VARCHAR")]

        [StringLength(50)]

        public string Email { get; set; }

        [Column(TypeName = "NVARCHAR")]

        [StringLength(150)]

        public string DiaChi { get; set; }
    }
}