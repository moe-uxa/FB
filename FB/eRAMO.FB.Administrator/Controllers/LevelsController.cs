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
    public class LevelsController : Controller
    {
        UnitOfWork ctx = new UnitOfWork();

        // GET: Levels
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Certificate.GetById<CertificatesModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            var list = ctx.Level.GetAll<LevelsModel>().Where(c => c.CertificateID == id.Value);
            return View(list);
        }

        // GET: Levels/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Certificate.GetById<CertificatesModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            LevelsModel LevelsModel = new LevelsModel()
            {
                CertificateID = id.Value
            };
            return View(LevelsModel);
        }

        // POST: Levels/Create
        [HttpPost]
        public ActionResult Create(LevelsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Level.Add(model);
                    ctx.Save();

                    return RedirectToAction("Index", new { id = model.CertificateID });
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Levels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Level.GetById<LevelsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Levels/Edit/5
        [HttpPost]
        public ActionResult Edit(LevelsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Level.Update(model);
                    ctx.Save();
                    return RedirectToAction("Index", new { id = model.CertificateID });
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // POST: Levels/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var model = ctx.Level.GetById<LevelsModel>(id.Value);
                if (model == null)
                {
                    return HttpNotFound();
                }

                ctx.Level.Delete(id.Value);
                ctx.Save();
                return RedirectToAction("Index", new { id = model.CertificateID });
            }
            catch
            {
                return RedirectToAction("Index", "Certificates");
            }
        }
    }
}
