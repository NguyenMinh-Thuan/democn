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
    
    public partial class DichVu
    {
        public DichVu()
        {
            this.SuDungDichVus = new HashSet<SuDungDichVu>();
        }
    
        public int ID { get; set; }
        public string TenDV { get; set; }
        public int IDLoai { get; set; }
        public Nullable<decimal> Gia { get; set; }
    
        public virtual LoaiDichVu LoaiDichVu { get; set; }
        public virtual ICollection<SuDungDichVu> SuDungDichVus { get; set; }
    }
}
