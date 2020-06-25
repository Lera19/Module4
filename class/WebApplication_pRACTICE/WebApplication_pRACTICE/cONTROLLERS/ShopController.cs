using BusinessLayer;
using BusinessLayer.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_pRACTICE.cONTROLLERS
{
    public class ShopController : Controller
    {
        private readonly ShopManager _shopManager;
        public ShopController()
        {
            _shopManager = new ShopManager();
        }
        // GET: Shop
        public ActionResult Index()
        {
            var products = _shopManager.GetAllProducts();
            return View(products);


        }
        public ActionResult ProductDetails(int id)
        {
            var product = _shopManager.GetProductId(id);
            return View(product);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            var product = _shopManager.GetProductId(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult EditProduct(ProductDTO product)
        {
            _shopManager.UpdateProduct(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult CreateProduct(ProductDTO product)
        {
            _shopManager.AddProduct(product);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult RemoveProduct(int id)
        {
            _shopManager.RemoveById(id);
            return RedirectToAction("Index");


        }
        //[HttpPost]
        //public ActionResult RemoveProduct(int id)
        //{
        //    _shopManager.RemoveById(id);
        //    return RedirectToAction("Index");
        //}
    }
}