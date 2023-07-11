using Eticaret.Core.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.EntityLayer.Concretes
{
    public class ShoppingCart : IEntity
    {
        public int cartid { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int productID { get; set; }
        public bool Status { get; set; }
    }
}

