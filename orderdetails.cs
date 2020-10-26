namespace EFExample
{
    public class orderdetails
    {
        
        public int Id { get; set; }
        public int productid { get; set; }
        public int unitprice { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }


        public Orders orders { get; set; }
        public int orderid { get; set; }


        public Product product { get; set; }
        public int ProductId { get; set; }

       

        public override string ToString()
        {
               return $"Id = {Id}, Orders = {orderid}, Product = {ProductId}”;

        }
    }

}

