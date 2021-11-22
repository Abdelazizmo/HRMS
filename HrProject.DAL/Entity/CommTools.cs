using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.DAL.Entity
{
    [Table("CommTools")]
    public class CommTools
    {
        public int Id { get; set; }
        public int Code { get; set; }

        [StringLength(50)]
        public string NameEnglish { get; set; }
    }
}
