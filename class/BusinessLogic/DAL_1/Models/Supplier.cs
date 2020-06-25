using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_1.Models
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new List<Product>();
            Shops = new List<Shop>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
