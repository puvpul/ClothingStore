using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.Api.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public decimal TotalCost { get; set; }
        public ICollection<OrderLine> Lines { get; set; }
    }
}