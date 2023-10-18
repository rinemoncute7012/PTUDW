using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace modelfirst.Models
{
    public class NhanVien
    {
        [Key]
        public string maphong { get; set; }
        public string manhanvien { get; set; }
        public string tennhanvien { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public Nullable<decimal> luong { get; set; }
        public string hinhanh { get; set; }


    }
}