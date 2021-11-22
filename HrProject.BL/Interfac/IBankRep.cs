using HrProject.BL.Model;
using HrProject.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.BL.Interfac
{
    public interface IBankRep
    {
        IEnumerable<BankVM> Get();
        BankVM GetById(int id);
        void Add(BankVM bnk);
        void Edit(BankVM bnk);
        void Delete(int id);
    }
}
