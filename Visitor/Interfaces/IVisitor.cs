using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Model;

namespace Visitor.Interfaces
{
    public interface IVisitor
    {
        void Visit(BankAccount account);
        void Visit(RealEstate realEstate);
        void Visit(Loan loan);
    }
}
