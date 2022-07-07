using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.DataTypes
{
    internal class Product
    {
        private string? name;
        private decimal price;
        private Storage storage ;

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public Product(string name,decimal price,Storage storage) : this(name,price)
        {
            this.storage = storage;
        }
        public string GetDetails()
        {
            return $"Product: {name} {price}";
        }

        public override string ToString()
        {
            return $@"Product: {name} {price}  {storage}";
        }

        // Getters
        public string? Name => name;
        public decimal Price => price;
        public Storage Storage => storage;
    }
}
