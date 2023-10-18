using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace modelfirst.Models
{
    public class PhongBan
    {
        [Key]
        public string maphong { get; set; }
        public string tenphong { get; set; }

    }
}