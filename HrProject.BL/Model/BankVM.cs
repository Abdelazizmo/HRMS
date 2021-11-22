using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.BL.Model
{
    public class BankVM
    {
        public int Id { get; set; }
        public int Code { get; set; }

        [StringLength(50)]
        public string NameArbic { get; set; }

        [StringLength(50)]
        public string NameEnglish { get; set; }

        public string Notes { get; set; }
    }
}
