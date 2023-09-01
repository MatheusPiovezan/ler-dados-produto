using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Globalization;

namespace Ler.Entities
{
    internal class ImportedProduct : Product
    {
        double CustomsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} $ {Price + CustomsFee} (Customs fee: $ {CustomsFee})");

            return sb.ToString();
        }
    }
}
