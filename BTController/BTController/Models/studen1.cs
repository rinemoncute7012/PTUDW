using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTController.Models
{
    public class studen1
    {
        [Required]
        public string ID { get; set; }
        public string Name { get; set; }
        public string img {get; set; }

    }
}