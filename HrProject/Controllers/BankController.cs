using HrProject.BL.Interfac;
using HrProject.BL.Model;
using HrProject.BL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HrProject.Controllers
{
    public class BankController : Controller
    {
        private readonly IBankRep bankRep;

        public BankController(IBankRep bankRep)
        {
            this.bankRep = bankRep;
        }
        public IActionResult Index()
        {
            var data = bankRep.Get();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BankVM bnk)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bankRep.Add(bnk);
                    return RedirectToAction("Index", "Bank");
                }

                return View(bnk);
            }
            catch (Exception ex)
            {
                EventLog log = new EventLog();
                log.Source = "Admin Dashboard";
                log.WriteEntry(ex.Message, EventLogEntryType.Error);

                return View(bnk);
            }


        }

        public IActionResult Edit(int id)
        {
            var data = bankRep.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(BankVM bnk)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bankRep.Edit(bnk);
                    return RedirectToAction("Index", "Bank");
                }

                return View(bnk);
            }
            catch (Exception ex)
            {
                EventLog log = new EventLog();
                log.Source = "Admin Dashboard";
                log.WriteEntry(ex.Message, EventLogEntryType.Error);

                return View(bnk);
            }
        }


        public IActionResult Delete(int id)
        {
            var data = bankRep.GetById(id);
            //if(data == null)
            //{

            //}
            return View(data);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            try
            {
                bankRep.Delete(id);
                return RedirectToAction("Index", "Bank");
            }
            catch (Exception ex)
            {
                EventLog log = new EventLog();
                log.Source = "Admin Dashboard";
                log.WriteEntry(ex.Message, EventLogEntryType.Error);

                return View();
            }
        }
    }
}
