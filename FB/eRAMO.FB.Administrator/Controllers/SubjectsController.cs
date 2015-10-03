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
    public class SubjectsController : Controller
    {
        UnitOfWork ctx = new UnitOfWork();

        // GET: Subjects
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Levels.GetById<LevelsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            var list = ctx.Subjects.GetAll<SubjectsModel>().Where(c => c.LevelID == id.Value);
            return View(list);
        }

        // GET: Subjects/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Levels.GetById<LevelsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            SubjectsModel SubjectsModel = new SubjectsModel()
            {
                LevelID = id.Value
            };
            return View(SubjectsModel);
        }

        // POST: Subjects/Create
        [HttpPost]
        public ActionResult Create(SubjectsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Subjects.Add(model);
                    ctx.Save();

                    return RedirectToAction("Index", new { id = model.LevelID });
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Subjects/Edit/5
        public ActionResult Edit(int? id)
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
            return View(model);
        }

        // POST: Subjects/Edit/5
        [HttpPost]
        public ActionResult Edit(SubjectsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Subjects.Update(model);
                    ctx.Save();
                    return RedirectToAction("Index", new { id = model.LevelID });
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // POST: Subjects/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
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

                ctx.Subjects.Delete(id.Value);
                ctx.Save();
                return RedirectToAction("Index", new { id = model.LevelID });
            }
            catch
            {
                return RedirectToAction("Index", "Levels");
            }
        }
    }
}
