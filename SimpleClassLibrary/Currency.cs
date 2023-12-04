using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    internal class Currency
    {
        public string Name { get; set; }
        public decimal ExRate { get; set; }

        public Currency(string name, decimal exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(Currency other)
        {
            Name = other.Name;
            ExRate = other.ExRate;
        }

        public override string ToString()
        {
            return $"{Name} - {ExRate} UAH";
        }
    }
}
