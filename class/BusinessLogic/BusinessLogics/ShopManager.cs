using DAL_1;
using DAL_1.Models;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BusinessLogics.ModelsDTO;

namespace BusinessLogics
{
    public class ShopManager
    {
        public readonly Mapper _mapper;
        public ShopManager()
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<Shop, ShopDTO>();
                  cfg.CreateMap<Supplier, SupplierDTO>();
                  cfg.CreateMap<Product, ProductDTO>();
              });
            _mapper=new Mapper(config);
        }
        public IList<ShopDTO> GetAllShops()
        {
            using (var context = new ShopContext())
            {
                //return context.Shops
                //    .Include(shop => shop.Suppliers.Select(supplier => supplier.Products)).ToList();
               return _mapper.Map<IList<ShopDTO>>(context.Shops.ToList()); //ленивая если загрузка использовать с virtual
            }
        }
        //public Shop GetFirstShop()
        //{
        //    using (var context = new ShopContext())
        //    {
        //        //var shop = context.Shops.First();
        //        //context.Entry(shop).Collection(s => s.Suppliers).Load();
        //        //return shop;
        //        return context.Shops.ToList();

        //    }
        //}
    }
}
