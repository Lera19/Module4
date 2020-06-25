using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Models
{
    public class Product
    {
        public Product()
        {
            Groups = new List<Group>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
