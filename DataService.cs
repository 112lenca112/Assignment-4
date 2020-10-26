using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFExample
{
    public class DataService
    {
        private readonly string _connectionString;

        public DataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataService()
        {
        }

        public IList<Category> GetCategories()
        {
            using var ctx = new NorthWindContext(_connectionString);
            return ctx.Categories.ToList();
        }


        public IList<Product> GetProducts()
        {
            using var ctx = new NorthWindContext(_connectionString);
            return ctx.Products.Include(x => x.Category).ToList();

        }


        public IList<orderdetails> GetOrderdetails()
        {
            using var ctx = new NorthWindContext(_connectionString);
            return ctx.Orderdetails.Include(x => x.ProductId).ToList();
           
        }


        public IList<Orders> GetOrders()
        {
            using var ctx = new NorthWindContext(_connectionString);
            return (IList<Orders>)ctx.Orders.Include(x => x.Category).ToList();
        }


    }
}