using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        ProductsDbContext DbContext;
        public ProductController()
        {
            DbContext = new ProductsDbContext();
        }
        public ActionResult Index()
        {
            var products = DbContext.Products.ToList();            
            
            return View(products);
        }

        public ActionResult Create()
        {

            ViewBag.category = DbContext.Categories.ToList();
            return View();
        }
    }
}