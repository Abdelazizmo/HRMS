using HrProject.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.BL.Interfac
{
    public interface ICommToolsRep
    {
        IEnumerable<CommToolsVM> Get();

    }
}
