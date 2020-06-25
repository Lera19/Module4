using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogics.ModelsDTO
{
    public class ShopDTO
    {
        public ShopDTO()
        {
            Suppliers = new List<SupplierDTO>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SupplierDTO> Suppliers { get; set; }
        
    }
}
