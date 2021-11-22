using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrProject.BL.Model;
using HrProject.BL.Interfac;

namespace HrProject.Controllers
{
    public class Communication : Controller
    {
        //private readonly ICommToolsRep commToolsRep;

        //public Communication(ICommToolsRep commToolsRep)
        //{
        //    this.commToolsRep = commToolsRep;
        //}
        public IActionResult Index()
        {
            //var data = commToolsRep.Get();
            //return View(data);
            return View();
        }
    }
}
