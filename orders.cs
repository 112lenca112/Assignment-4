using System;
namespace EFExample
{
    public class Orders
    {
        

        public int orderid { get; set; }
        public string customerid { get; set; }
        public int employeeid { get; set; }
        public DateTime orderdate { get; set; }
        public DateTime requiredate { get; set; }
        public DateTime shippeddate { get; set; }
        public int freight { get; set; }
        public string shipname { get; set; }
        public string shipaddress { get; set; }
        public string shipcity { get; set; }
        public string shippostalcode { get; set; }
        public string shipcountry { get; set; }



        public override string ToString()
        {
            return $"Id = {orderid}";
        }
    }
}

