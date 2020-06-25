using DAL_1;
using DAL_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogic
{
    public class ShopManager
    {
        public IList<Shop> GetAllShops()
        {
            using(var context = new ShopContext())
            {
                return context.Shops
                    .Include(shop=>shop.Suppliers.Select(supplier=>supplier.Products)).ToList();
            }
        }
    }
}
