using System;
using ADOExample;
using Npgsql;

namespace ADOExample
{

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }


    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Unitprice { get; set; }
        public string Quantityperunit { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Unitprice = {Unitprice},Quantityperunit = {Quantityperunit} Category = {Category.Name}";
        }
    }
}

    class orders
    {
        public int Id { get; set; }
        
        public override string ToString()
        {
            return $"Id = {Id}";
        }
    }


    class Orderdetails
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public orders orders { get; set; }




        public override string ToString()
        {
        return $"Id = {Id}, orders = {orders}, Product = {product}”;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "host=localhost;db=northwind;uid=postgres;pwd=1234";
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select categoryid, categoryname from categories";
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var category = new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };

                Console.WriteLine(category);

            }


            cmd.Connection = conn;
            cmd.CommandText = "select productid, productname from products";
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var orders = new orders
                {
                    Id = reader.GetInt32(0)

                };

                Console.WriteLine(orders);
            }

            cmd.Connection = conn;
            cmd.CommandText = "select * from orderdetails";
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var orderdetails = new Orderdetails
                {
                    Id = reader.GetInt32(0)

                };

                Console.WriteLine(orderdetails);
            }


        }



    }

    
}
