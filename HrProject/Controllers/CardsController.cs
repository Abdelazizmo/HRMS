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
    public class CardsController : Controller
    {
        private readonly ICardTypeRep cardsTypeRep;

        public CardsController(ICardTypeRep cardsTypeRep)
        {
            this.cardsTypeRep = cardsTypeRep;
        }

        public IActionResult Index()
        {
            var data = cardsTypeRep.Get();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CardsTypeVM crd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cardsTypeRep.Add(crd);
                    return RedirectToAction("Index", "Cards");
                }

                return View(crd);
            }
            catch (Exception ex)
            {
                EventLog log = new EventLog();
                log.Source = "Admin Dashboard";
                log.WriteEntry(ex.Message, EventLogEntryType.Error);

                return View(crd);
            }

        }

        public IActionResult Edit(int id)
        {
            var data = cardsTypeRep.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(CardsTypeVM crd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cardsTypeRep.Edit(crd);
                    return RedirectToAction("Index", "Cards");
                }

                return View(crd);
            }
            catch (Exception ex)
            {
                EventLog log = new EventLog();
                log.Source = "Admin Dashboard";
                log.WriteEntry(ex.Message, EventLogEntryType.Error);

                return View(crd);
            }
        }


        public IActionResult Delete(int id)
        {
            var data = cardsTypeRep.GetById(id);
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
                cardsTypeRep.Delete(id);
                return RedirectToAction("Index", "Cards");
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
