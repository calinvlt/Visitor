using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;
using Visitor.Model;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Assets = new List<IAsset>();

            person.Assets.AddRange(new List<BankAccount> { new BankAccount { Amount = 100 }, new BankAccount { Amount = 150 }});
            person.Assets.AddRange(new List<RealEstate> { new RealEstate { ValueAmount = 20 } });
            person.Assets.AddRange(new List<Loan> { new Loan { InterestRate = 1.2, Own = 54 } });

            var visitor = new NetWorthVisitor();
            person.Accept(visitor);
            
            Console.WriteLine(visitor.Total);
        }
    }
}
