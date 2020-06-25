using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Models
{
    public class Group
    {
        public Group()
        {
            Products = new List<Product>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
