using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops2.Model
{
    public class Phone
    {
        [Key]
        public int id { get; set; }
        public string company { get; set; }
        public string name { get; set; }
        public int price { get; set; } 
    }
}
