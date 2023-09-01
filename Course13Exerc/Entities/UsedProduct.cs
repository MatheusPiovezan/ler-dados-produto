using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} (used) $ {Price} (Manufacture date: {ManufactureDate})");

            return sb.ToString();
        }
    }
}
