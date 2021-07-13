using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckboxList.Models;

namespace CheckboxList.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductModel product = new ProductModel();
            using(AzuredbEntities db=new AzuredbEntities())
            {
                product.Products = db.Products.ToList<Product>();
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Index(ProductModel obi)
        {

            var SelectedProducts = obi.Products.Where(x => x.Ischecked == true).ToList<Product>();
            return Content(String.Join(",", SelectedProducts.Select(x => x.ProductId)));
           
        }
    }
}