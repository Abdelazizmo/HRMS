using AutoMapper;
using HrProject.BL.Model;
using HrProject.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<CardsType, CardsTypeVM>();
            CreateMap<CardsTypeVM, CardsType>();

            CreateMap<CommTools, CommToolsVM>();
            CreateMap<CommToolsVM, CommTools>();

            CreateMap<Bank, BankVM>();
            CreateMap<BankVM, Bank>();
        }
    }
}
