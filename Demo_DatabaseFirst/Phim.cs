//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phim
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public string Mota { get; set; }
        public string NoiDung { get; set; }
        public string ImageName { get; set; }
        public string TacGia { get; set; }
        public Nullable<int> ChuDeId { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayDuyet { get; set; }
    
        public virtual ChuDe ChuDe { get; set; }
    }
}
