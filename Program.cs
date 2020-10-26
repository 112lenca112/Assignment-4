using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFExample
{
    class Program
    {
        private static readonly object ctx;
        private static bool Orderdetails;

        static void Main(string[] args)
        {



            /* Get a single order by ID*/

            using var ctx = new NorthWindContext();
            foreach (var category in ctx.Categories)
            {

                Console.WriteLine(category);
            }


            /* GET ALL ORDERS + PRODUCT AND CATEGORY */



            //using var ctx = new NorthWindContext();
            //foreach (var orders in ctx.Orders.Include(x => x.Category))
            //{
            //    Console.WriteLine(orders);
            //}


            /*GET ORDER BY SHIPPING NAME */







            /* ALL ORDERS */





            /* ORDERS*/

            /* Get the details for a specific order ID*/







            /* Get the details for a specific product ID*/

            //var dataService = new DataService();
            //foreach (var Product in dataService.GetOrderdetails())
            //{
            //    Console.WriteLine(Orderdetails);
            //}







            /*PRODUCT*/

            /* Get a single product by ID */

            //var dataService = new DataService();
            //foreach (var Product in dataService.GetProducts())
            //{
            //    Console.WriteLine(Product);
            //}



            /* Get a list of products that contains a substring*/





            /* GET ALL PRODUCTS BY CATEGORY ID*/

            //var dataService = new DataService();

            //foreach (var product in dataService.GetProducts())
            //{
            //    Console.WriteLine(Product);
            //}



            /* CATEGORY*/

            ///* GET cATEGORY ID AND NAME*/
            //var dataService = new DataService();
            //foreach (var elem:Producy in dataService.GetCategories())
            //{
            //    Console.WriteLine(category);
            //}




            /* UPDATE CATEGORY*/
            //using var ctx = new NorthWindContext();
            //var cat= ctx.Categories.Find(9);

            //cat.Name = "UpdateTest";
            //cat.Description = "fdsjfsldkjfsdlkf";
            //ctx.SaveChanges();

            //foreach (var category in ctx.Categories)
            //{
            //  Console.WriteLine(category);
            //}





            /* ADD SOMETHING NEW '*/

            //using var ctx = new NorthWindContext();
            //var maxId = ctx.Categories.Max(x => x.Id);
            //ctx.Categories.Add(new Category {Id = maxId + 1, Name = "Testing"});
            //ctx.SaveChanges();

            //foreach (var category in ctx.Categories)
            //{
            //    Console.WriteLine(category);
            //}


        }
    }
}
