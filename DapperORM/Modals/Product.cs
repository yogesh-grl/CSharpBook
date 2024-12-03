using Microsoft.AspNetCore.Mvc;

namespace DapperORM.Modals
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public object Data { get; set; }
        public string Tag { get; set; }
    }
}
