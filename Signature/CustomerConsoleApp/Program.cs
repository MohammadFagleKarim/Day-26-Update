using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Signature.Model.Model;
using Signature.BLL.BLL;


namespace CustomerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager _customerManager = new CustomerManager();
            Customer customer = new Customer()
            {
                Code = "0002",
                Name = "Rezwana",
                Address = "Mirpur-13",
                Email = "rrreza@gmail.com",
                Contact = "01676852825",
                LoyalityPoint = 10

            };

            //Add
            if (_customerManager.Add(customer))
            {
                Console.WriteLine("Saved");
            }
            else
            {
                Console.WriteLine("Not Saved");
            }

            ////Delete
            //if (_customerManager.Delete(4))
            //{
            //    Console.WriteLine("Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted");
            //}

            //// Update
            // customer.Id = 2;
            // customer.Code = "002";
            // customer.Name = "Ananna";
            // customer.Address = "Mirpur-13";
            // customer.Email = "rrananna@gmail.com";
            // customer.Contact = "01676235155";

            // if (_customerManager.Update(customer))
            // {
            //     Console.WriteLine("Updated");
            // }
            // else
            // {
            //     Console.WriteLine("Not Updated");
            // }

            //var customers = _customerManager.GetAll();
            // var acustomer = _customerManager.GetById(1);


            Console.ReadKey();
        }
    }
}
