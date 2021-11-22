using HrProject.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.BL.Interfac
{
    public interface ICardTypeRep
    {
        IEnumerable<CardsTypeVM> Get();
        CardsTypeVM GetById(int id);
        void Add(CardsTypeVM dpt);
        void Edit(CardsTypeVM dpt);
        void Delete(int id);
    }
}
