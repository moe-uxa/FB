using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eRAMO.FB.Model;
using eRAMO.FB.Business;
using eRAMO.FB.Manager;

namespace eRAMO.FB.Administrator.Controllers
{
    public class ReadingsController : Controller
    {
        UnitOfWork ctx = new UnitOfWork();

        // GET: Readings
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.StudySessions.GetById<StudySessionsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            var list = ctx.Readings.GetAll<ReadingsModel>().Where(c => c.StudySessionID == id.Value);
            return View(list);
        }

        // GET: Readings/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.StudySessions.GetById<StudySessionsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            ReadingsModel ReadingsModel = new ReadingsModel()
            {
                StudySessionID = id.Value
            };
            return View(ReadingsModel);
        }

        // POST: Readings/Create
        [HttpPost]
        public ActionResult Create(ReadingsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Readings.Add(model);
                    ctx.Save();

                    return RedirectToAction("Index", new { id = model.StudySessionID });
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Readings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Readings.GetById<ReadingsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Readings/Edit/5
        [HttpPost]
        public ActionResult Edit(ReadingsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Readings.Update(model);
                    ctx.Save();
                    return RedirectToAction("Index", new { id = model.StudySessionID });
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // POST: Readings/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var model = ctx.Readings.GetById<ReadingsModel>(id.Value);
                if (model == null)
                {
                    return HttpNotFound();
                }

                ctx.Readings.Delete(id.Value);
                ctx.Save();
                return RedirectToAction("Index", new { id = model.StudySessionID });
            }
            catch
            {
                return RedirectToAction("Index", "StudySessions");
            }
        }
    }
}
