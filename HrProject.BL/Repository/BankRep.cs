using AutoMapper;
using HrProject.BL.Interfac;
using HrProject.BL.Model;
using HrProject.DAL.Database;
using HrProject.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.BL.Repository
{
    public class BankRep : IBankRep
    {
        private readonly IMapper mapper;

        public BankRep(IMapper _Mapper)
        {
            mapper = _Mapper;
        }

        HrContext db = new HrContext();

        public IEnumerable<BankVM> Get()
        {
            var data = db.Bank.Select(a => new BankVM
            {
                Id = a.Id,
                Code = a.Code,
                NameArbic = a.NameArbic,
                NameEnglish = a.NameEnglish,
                Notes = a.Notes

            });

            return data;
        }

        //public IEnumerable<Bank> Get()
        //{
        //    var data = db.Bank.Select(a => a
        //    );
        //    return (data);
        //}

        public BankVM GetById(int id)
        {
            var data = db.Bank.Where(a => a.Id == id)
                                    .Select(a => new BankVM
                                    {
                                        Id = a.Id,
                                        Code = a.Code,
                                        NameArbic = a.NameArbic,
                                        NameEnglish = a.NameEnglish,
                                        Notes = a.Notes
                                    })
                                    .FirstOrDefault();
            return data;
        }

        //public Bank GetById(int id)
        //{
        //    var data = db.Bank.Where(a => a.Id == id)
        //        .FirstOrDefault();
        //    return data;
        //}
        public void Add(BankVM bnk)
        {
            var data = mapper.Map<Bank>(bnk);
            db.Add(data);
            db.SaveChanges();
        }
        public void Edit(BankVM bnk)
        {
            var data = mapper.Map<Bank>(bnk);
            db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var DeleteObject = db.Bank.Find(id);
            db.Bank.Remove(DeleteObject);
            db.SaveChanges();
        }

    }
}
