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
    public class CertificatesController : Controller
    {
        UnitOfWork ctx = new UnitOfWork();

        // GET: Certificates
        public ActionResult Index()
        {
            var list = ctx.Certificates.GetAll<CertificatesModel>();
            return View(list);
        }

        // GET: Certificates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Certificates/Create
        [HttpPost]
        public ActionResult Create(CertificatesModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Certificates.Add(model);
                    ctx.Save();

                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        // GET: Certificates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Certificates.GetById<CertificatesModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Certificates/Edit/5
        [HttpPost]
        public ActionResult Edit(CertificatesModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Certificates.Update(model);
                    ctx.Save();
                    return RedirectToAction("Index");
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // POST: Certificates/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var model = ctx.Certificates.GetById<CertificatesModel>(id.Value);
                if (model == null)
                {
                    return HttpNotFound();
                }

                ctx.Certificates.Delete(id.Value);
                ctx.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
