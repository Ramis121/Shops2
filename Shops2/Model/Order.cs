using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops2.Model
{
    public class Order
    {
        public int orderId { get; set; }
        public string user { get; set; } // имя фамилия покупателя
        public string address { get; set; } // адрес покупателя
        public string contactPhone { get; set; } // контактный телефон покупателя

        public int phoneId { get; set; } // ссылка на связанную модель Phone
    }
}
