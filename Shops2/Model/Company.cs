using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops2.Model
{
    public class Company
    {
        [Key]
        public int id { get; set; }
        public string name_company { get; set; }
    }
}
