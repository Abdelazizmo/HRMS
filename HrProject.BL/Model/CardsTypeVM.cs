using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.BL.Model
{
    public class CardsTypeVM
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string NameArbic { get; set; }
        public string NameEnglish { get; set; }
        public bool IsCreationPlace { get; set; }
        public bool IsCreationDate { get; set; }
        public bool IsExpiredDate { get; set; }
        public bool IsRenewableDate { get; set; }
        public bool IsRenwableValue { get; set; }
        public bool IsRepeated { get; set; }
        public bool IsHasAttatchment { get; set; }
        public string Notes { get; set; }
    }
}
