using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signature.BLL.BLL;
using Signature.Model.Model;

namespace CategoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager _categoryManager = new CategoryManager();

            Category category = new Category()
            {
                Code = "0001",
                Name = "Arafat",

            };

            //Add
            if (_categoryManager.Add(category))
            {
                Console.WriteLine("Saved");
            }
            else
            {
                Console.WriteLine("Not Saved");
            }

            //Delete
            if (_categoryManager.Delete(1))
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Not Deleted");
            }

            //Update
            category.Id = 1;
            category.Code = "0002";
            category.Name = "Mobile";



            if (_categoryManager.Update(category))
            {
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("Not Updated");
            }


            var categories = _categoryManager.GetAll();
            var acategory = _categoryManager.GetById(1);

            Console.ReadKey();
        }
    }
}
