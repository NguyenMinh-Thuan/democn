//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuDungDichVu
    {
        public int ID { get; set; }
        public int idBangThuePhong { get; set; }
        public int idDichVu { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    
        public virtual BangThuePhong BangThuePhong { get; set; }
        public virtual DichVu DichVu { get; set; }
    }
}
