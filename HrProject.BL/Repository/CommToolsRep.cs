using AutoMapper;
using HrProject.BL.Interfac;
using HrProject.BL.Model;
using HrProject.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrProject.DAL.Entity;


namespace HrProject.BL.Repository
{
    public class CommToolsRep : ICommToolsRep
    {
        private readonly IMapper mapper;
        public CommToolsRep(IMapper _Mapper)
        {
            mapper = _Mapper;
        }

        HrContext db = new HrContext();

        public IEnumerable<CommToolsVM> Get()
        {
            var data = db.CommTools.Select(a => new CommToolsVM
            {
                Id = a.Id,
                Code = a.Code,
                NameEnglish = a.NameEnglish
            });

            return data;
        }
    }
}
