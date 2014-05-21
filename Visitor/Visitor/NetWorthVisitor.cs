using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Visitor
{
    public class NetWorthVisitor : IVisitor
    {
        public int Total { get; set; }

        public void Visit(Model.BankAccount account)
        {
            Total += account.Amount;
        }

        public void Visit(Model.RealEstate realEstate)
        {
            Total += realEstate.ValueAmount;
        }

        public void Visit(Model.Loan loan)
        {
            Total -= loan.Own;
        }
    }
}
