using BusinessLayer;
using BusinessLayer.ModelDTO;
using System.Web.Mvc;

namespace Presentation_WEB.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreManager _storeManager;
        public StoreController()
        {
            _storeManager = new StoreManager();
        }
        // GET: Store
        public ActionResult Index()
        {
            var books = _storeManager.GetAllBooks();
            return View(books);
        }
        
        [HttpGet]
        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBook(BookDTO book)
        {
            _storeManager.AddBook(book);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult RemoveBook(int id)
        {
            _storeManager.RemoveById(id);
            return RedirectToAction("Index");


        }


        [HttpGet]
        public ActionResult EditBook(int id)
        {
            var books = _storeManager.GetBookID(id);
            return View(books);
        }
        [HttpPost]
        public ActionResult EditBook(BookDTO book)
        {
            _storeManager.UpdateBook(book);
            return RedirectToAction("Index");
        }

    }
}