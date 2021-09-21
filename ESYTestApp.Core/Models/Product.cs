using System;

namespace ESYTestApp.Core.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
    }
}