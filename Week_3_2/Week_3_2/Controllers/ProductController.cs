using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week_3_2.DAL;

namespace Week_3_2.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(repository.GetProducts());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(repository.GetProductByID(id));
        }

    }
}
