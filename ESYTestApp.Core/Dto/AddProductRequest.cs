using System;

namespace ESYTestApp.Core.Dto
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
    }
}