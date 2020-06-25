using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_1.Models
{
    public class Shop
    {
        public Shop()
        {
            Suppliers = new List<Supplier>();
        }
        public int ID { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        
    }
}
