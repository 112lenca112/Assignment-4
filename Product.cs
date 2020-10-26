using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Unitprice { get; set; }

        public string Quantityperunit { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Unitprice = {Unitprice},Quantityperunit = {Quantityperunit} Category = {Category.Name}";
        }
    }
}
