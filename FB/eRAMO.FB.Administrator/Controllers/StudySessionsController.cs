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
    public class StudySessionsController : Controller
    {
        UnitOfWork ctx = new UnitOfWork();

        // GET: StudySessions
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Subjects.GetById<SubjectsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            var list = ctx.StudySessions.GetAll<StudySessionsModel>().Where(c => c.SubjectID == id.Value);
            return View(list);
        }

        // GET: StudySessions/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Subjects.GetById<SubjectsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            StudySessionsModel StudySessionsModel = new StudySessionsModel()
            {
                SubjectID = id.Value
            };
            return View(StudySessionsModel);
        }

        // POST: StudySessions/Create
        [HttpPost]
        public ActionResult Create(StudySessionsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.StudySessions.Add(model);
                    ctx.Save();

                    return RedirectToAction("Index", new { id = model.SubjectID });
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: StudySessions/Edit/5
        public ActionResult Edit(int? id)
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
            return View(model);
        }

        // POST: StudySessions/Edit/5
        [HttpPost]
        public ActionResult Edit(StudySessionsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.StudySessions.Update(model);
                    ctx.Save();
                    return RedirectToAction("Index", new { id = model.SubjectID });
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // POST: StudySessions/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
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

                ctx.StudySessions.Delete(id.Value);
                ctx.Save();
                return RedirectToAction("Index", new { id = model.SubjectID });
            }
            catch
            {
                return RedirectToAction("Index", "Subjects");
            }
        }
    }
}
