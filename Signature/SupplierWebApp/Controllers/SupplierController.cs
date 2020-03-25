using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Signature.BLL.BLL;
using Signature.Model.Model;

namespace SupplierWebApp.Controllers
{
    public class SupplierController : Controller
    {
        Supplier supplier = new Supplier();
        SupplierManager _supplierManager = new SupplierManager();

        // GET: Supplier

        [HttpGet]
        public ActionResult Add()
        {
            Supplier supplier = new Supplier();
            return View(supplier);
        }

        [HttpPost]
        public ActionResult Add(Supplier supplier)
        {
            string message = "<h3>Supplier info</h3>";
            if (_supplierManager.Add(supplier))
            {
                message = "Saved";
            }
            else
            {
                message = "Not saved";
            }

            ViewBag.Message = message;
            return View(supplier);
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            //supplier.Id =Convert.ToInt32(Id);
            var supplier = _supplierManager.GetById(Convert.ToInt32(Id));
            return View(supplier);
        }
        [HttpPost]
        public ActionResult Edit(Supplier supplier)
        {
            string message = "<h3>Supplier info</h3>";
            if (_supplierManager.Update(supplier))
            {
                message = "Edited";
            }
            else
            {
                message = "Not Edited";
            }

            ViewBag.Message = message;
            return View(supplier);
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            //supplier.Id =Convert.ToInt32(Id);
            var supplier = _supplierManager.GetById(Convert.ToInt32(Id));
            return View(supplier);
        }

        [HttpPost]
        public ActionResult Delete(Supplier supplier)
        {
            string message = "<h3>Supplier info</h3>";
            if (_supplierManager.Delete(supplier.Id))
            {
                message = "Deleted";
            }
            else
            {
                message = "Not Deleted";
            }

            ViewBag.Message = message;
            return View(supplier);
        }

        [HttpGet]
        public ActionResult Show()
        {
            var supplier = _supplierManager.GetAll();
            return View(supplier);
        }

        [HttpPost]
        public ActionResult Show(Supplier supplier)
        {
            var suppliers = _supplierManager.GetAll();
            if (supplier.Name!=null)
            {
                 suppliers = suppliers.Where(c => c.Name.ToLower().Contains(supplier.Name.ToLower())).ToList();
            }
            if (supplier.Contact != null)
            {
                suppliers = suppliers.Where(c => c.Contact.ToLower().Contains(supplier.Contact.ToLower())).ToList();
            }
            if (supplier.Email != null)
            {
                suppliers = suppliers.Where(c => c.Email.ToLower().Contains(supplier.Email.ToLower())).ToList();
            }
            return View(suppliers);
        }
    }
}