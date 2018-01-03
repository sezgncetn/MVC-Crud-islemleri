using mvcCrudIslemleri.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCrudIslemleri.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            using (ProjectContext context = new ProjectContext())
            {
                context.Products.Add();

            }
                return View();
        }
    }
}