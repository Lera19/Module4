using AutoMapper;
using BusinessLayer.ModelsDTO;
using DataAcessLayer;
using DataAcessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class ShopManager
    {
        public readonly ShopRepository _shoprepository;
        public readonly Mapper _mapper;
        public ShopManager()
        {
            _shoprepository = new ShopRepository();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<Group, GroupDTO>();
                cfg.CreateMap<ProductDTO, Product>();
            });

            _mapper = new Mapper(conf);
        }

        public IList<ProductDTO> GetAllProducts()
        {
            return _mapper.Map<IList<ProductDTO>>(_shoprepository.GetAllProducts());
        }
        public void UpdateProduct(ProductDTO product)
        {
            _shoprepository.UpdateProduct(_mapper.Map<Product>(product));
        }
        public ProductDTO GetProductId(int id)
        {
            return _mapper.Map<ProductDTO>(_shoprepository.GetProductID(id));
        }
        public void AddProduct(ProductDTO productDTO)
        {
            _shoprepository.SaveProduct(_mapper.Map<Product>(productDTO));
        }

        public void RemoveById(int id)
        {
            _shoprepository.RemoveProduct(id);


        }
    }
}
