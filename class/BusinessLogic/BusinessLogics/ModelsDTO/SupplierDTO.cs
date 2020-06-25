using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogics.ModelsDTO
{
    public class SupplierDTO
    {
        public SupplierDTO()
        {
            Products = new List<ProductDTO>();
            Shops = new List<ShopDTO>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ShopDTO> Shops { get; set; }
        public virtual ICollection<ProductDTO> Products { get; set; }
    }
}
