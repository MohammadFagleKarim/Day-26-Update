using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Signature.BLL.BLL;
using Signature.Model.Model;

namespace ProductWebApp.Controllers
{
    public class ProductController : Controller
    {
        Product product = new Product();

        ProductManager _ProductManager = new ProductManager();

        [HttpGet]
        public ActionResult Add()
        {
            Product product = new Product();
            return View(product);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            string message = "<h3>Product info</h3>";
            if (_ProductManager.Add(product))
            {
                message = "Saved";
            }
            else
            {
                message = "Not saved";
            }

            ViewBag.Message = message;
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            Product product = new Product();
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            string message = "<h3>Product info</h3>";
            if (_ProductManager.Update(product))
            {
                message = "Edited";
            }
            else
            {
                message = "Not Edited";
            }

            ViewBag.Message = message;
            return View(product);
        }

        [HttpGet]
        public ActionResult Delete()
        {
            Product product = new Product();
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            string message = "<h3>Product info</h3>";
            if (_ProductManager.Delete(product.Id))
            {
                message = "Deleted";
            }
            else
            {
                message = "Not Deleted";
            }

            ViewBag.Message = message;
            return View(product);
        }

        [HttpGet]
        public ActionResult Show()
        {
            var product = _ProductManager.GetAll();
            return View(product);
        }
        [HttpPost]
        public ActionResult Show(Product product)
        {
            var products = _ProductManager.GetAll();
            if (product.Code != null)
            {
                products = products.Where(c => c.Code.ToLower().Contains(product.Code.ToLower())).ToList();
            }
            if (product.Name != null)
            {
                products = products.Where(c => c.Name.ToLower().Contains(product.Name.ToLower())).ToList();
            }

            return View(products);
        }
    }
}