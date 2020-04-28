using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingEchoBot.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
