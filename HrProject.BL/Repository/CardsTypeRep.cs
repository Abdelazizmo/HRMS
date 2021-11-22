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
    public class CardsTypeRep : ICardTypeRep
    {
        private readonly IMapper mapper;
        public CardsTypeRep(IMapper _Mapper)
        {
            mapper = _Mapper;
        }
        //private readonly HrContext db;

        //public CardsTypeRep(HrContext db)
        //{
        //    this.db = db;
        //}

        HrContext db = new HrContext();
        

        public IEnumerable<CardsTypeVM> Get()
        {
            var data = db.CardsType.Select(a => new CardsTypeVM { 
                Id = a.Id ,
                NameArbic = a.NameArbic,
                NameEnglish = a.NameEnglish,
                Code = a.Code,
                IsCreationDate = a.IsCreationDate,
                IsCreationPlace = a.IsCreationPlace,
                IsExpiredDate = a.IsExpiredDate,
                IsHasAttatchment = a.IsHasAttatchment,
                IsRenewableDate= a.IsRenewableDate,
                IsRenwableValue = a.IsRenwableValue,
                IsRepeated = a.IsRepeated,
                Notes = a.Notes
            });

            return data;
        }
        public CardsTypeVM GetById(int id)
        {
            var data = db.CardsType.Where(a => a.Id == id)
                                    .Select(a => new CardsTypeVM
                                    {
                                        Id = a.Id,
                                        NameArbic = a.NameArbic,
                                        NameEnglish = a.NameEnglish,
                                        Code = a.Code,
                                        IsCreationDate = a.IsCreationDate,
                                        IsCreationPlace = a.IsCreationPlace,
                                        IsExpiredDate = a.IsExpiredDate,
                                        IsHasAttatchment = a.IsHasAttatchment,
                                        IsRenewableDate = a.IsRenewableDate,
                                        IsRenwableValue = a.IsRenwableValue,
                                        IsRepeated = a.IsRepeated,
                                        Notes = a.Notes
                                    })
                                    .FirstOrDefault();
            return data;
        }

        public void Add(CardsTypeVM dpt)
        {
            // Mapping
            //CardsType c = new CardsType();
            //c.NameArbic = dpt.NameArbic;
            //c.NameEnglish = dpt.NameEnglish;
            //c.Code = dpt.Code;
            //c.IsCreationDate = dpt.IsCreationDate;
            //c.IsCreationPlace = dpt.IsCreationPlace;
            //c.IsExpiredDate = dpt.IsExpiredDate;
            //c.IsHasAttatchment = dpt.IsHasAttatchment;
            //c.IsRenewableDate = dpt.IsRenewableDate;
            //c.IsRenwableValue = dpt.IsRenwableValue;
            //c.IsRepeated = dpt.IsRepeated;
            //c.Notes = dpt.Notes;

            //db.CardsType.Add(c);

            var data = mapper.Map<CardsType>(dpt);
            db.CardsType.Add(data);
            db.SaveChanges();
        }

        public void Edit(CardsTypeVM crd)
        {
            //var OldData = db.CardsType.Find(dpt.Id);

            //OldData.NameArbic = dpt.NameArbic;
            //OldData.NameEnglish = dpt.NameEnglish;
            //OldData.Code = dpt.Code;
            //OldData.IsCreationDate = dpt.IsCreationDate;
            //OldData.IsCreationPlace = dpt.IsCreationPlace;
            //OldData.IsExpiredDate = dpt.IsExpiredDate;
            //OldData.IsHasAttatchment = dpt.IsHasAttatchment;
            //OldData.IsRenewableDate = dpt.IsRenewableDate;
            //OldData.IsRenwableValue = dpt.IsRenwableValue;
            //OldData.IsRepeated = dpt.IsRepeated;
            //OldData.Notes = dpt.Notes;

            var data = mapper.Map<CardsType>(crd);
            db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var DeletedObject = db.CardsType.Find(id);
            db.CardsType.Remove(DeletedObject);
            db.SaveChanges();
        }
    }
}
