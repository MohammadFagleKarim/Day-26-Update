using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Signature.Model.Model;
using Signature.BLL.BLL;

namespace ProductConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager _productManager = new ProductManager();
            Product product = new Product()
            {
                CategoryId = 2,
                Code = "PR03",
                Name = "Burger",
                ReorderLevel = 10,
                Description = "Large Size"
            };

            //Add
            if (_productManager.Add(product))
            {
                Console.WriteLine("Saved");
            }
            else
            {
                Console.WriteLine("Not Saved");
            }


            ////Delete
            //if (_productManager.Delete(3))
            //{
            //    Console.WriteLine("Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted");
            //}

            ////Update
            //product.Id = 5;
            //product.CategoryId = 3;
            //product.Code = "PR05";
            //product.Name = "Spicy Pizza";
            //product.ReorderLevel = 15;
            //product.Description = "Small Size";


            //if (_productManager.Update(product))
            //{
            //    Console.WriteLine("Updated");
            //}
            //else
            //{
            //    Console.WriteLine("Not Updated");
            //}

            var products = _productManager.GetAll();
            //var aproduct = _productManager.GetById(1);

            Console.ReadKey();
        }
    }
}
