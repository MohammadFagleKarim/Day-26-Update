using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signature.DatabaseContext.DatabaseContext;
using  Signature.Model.Model;
using Signature.BLL.BLL;

namespace SupplierConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SupplierManager _supplierManager = new SupplierManager();
           

            Supplier supplier = new Supplier()
            {
                Code = "s003",
                Name = "Sakib",
                Address = "Dhaka",
                Contact = "01519222000",
                Email = "hb@gmail.com",
                Contact_Person = "Md. Hasib"
            };



            //Add for Supplier
            if (_supplierManager.Add(supplier))
            {
                Console.WriteLine("Saved");
            }
            else
            {
                Console.WriteLine("Not Saved");
            }
            //Delete for Supplier
            //if (_supplierManager.Delete(2))
            //{
            //    Console.WriteLine("Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted");
            //}

            //Update for supplier
            //supplier.Id = 1;
            //supplier.Name = "Siam";
            //supplier.Address = "Comilla";
            //if (_supplierManager.Update(supplier))
            //{
            //    Console.WriteLine("Updated");
            //}
            //else
            //{
            //    Console.WriteLine("Not Updated");
            //}
            //
            //Get all for supplier
            //var asupplier = _supplierManager.GetAll();
           // var asupplier = _supplierManager.GetById(1);



           Console.ReadKey();
        }
    }
}
