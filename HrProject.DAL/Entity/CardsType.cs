using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace HrProject.DAL.Entity
{
    [Table("CardsType")]
    public class CardsType
    {
        public int Id { get; set; }
        public int Code { get; set; }

        [StringLength(50)]
        public string NameArbic { get; set; }

        [StringLength(50)]
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
