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
    public class SubCategoriesController : Controller
    {
        UnitOfWork ctx = new UnitOfWork();

        // GET: SubCategories
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Reading.GetById<ReadingsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            var list = ctx.SubCategory.GetAll<SubCategoriesModel>().Where(c => c.ReadingID == id.Value);
            return View(list);
        }

        // GET: SubCategories/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Reading.GetById<ReadingsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }

            SubCategoriesModel SubCategoriesModel = new SubCategoriesModel()
            {
                ReadingID = id.Value
            };
            return View(SubCategoriesModel);
        }

        // POST: SubCategories/Create
        [HttpPost]
        public ActionResult Create(SubCategoriesModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.SubCategory.Add(model);
                    ctx.Save();

                    return RedirectToAction("Index", new { id = model.ReadingID });
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: SubCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.SubCategory.GetById<SubCategoriesModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: SubCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(SubCategoriesModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.SubCategory.Update(model);
                    ctx.Save();
                    return RedirectToAction("Index", new { id = model.ReadingID });
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // POST: SubCategories/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var model = ctx.SubCategory.GetById<SubCategoriesModel>(id.Value);
                if (model == null)
                {
                    return HttpNotFound();
                }

                ctx.SubCategory.Delete(id.Value);
                ctx.Save();
                return RedirectToAction("Index", new { id = model.ReadingID });
            }
            catch
            {
                return RedirectToAction("Index", "Readings");
            }
        }
    }
}
