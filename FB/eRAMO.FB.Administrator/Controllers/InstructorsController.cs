using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eRAMO.FB.Model;
using eRAMO.FB.Business;
using eRAMO.FB.Manager;
using eRAMO.FB.Business.Helpers;

namespace eRAMO.FB.Administrator.Controllers
{
    public class InstructorsController : Controller
    {
        UnitOfWork ctx = new UnitOfWork();

        // GET: Instructors
        public ActionResult Index()
        {
            var list = ctx.Instructor.GetAll<InstructorsModel>();
            return View(list);
        }

        // GET: Instructors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instructors/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(InstructorsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //try
                    //{
                    byte[] image = Html5ImageUploaderHelper.GetImageFromUploader(model.avatar_values); ;
                    string imagePath = "/Images/Instructors/";
                    model.PhotoUrl = Html5ImageUploaderHelper.SaveBase64ImageToFile(image, imagePath, Guid.NewGuid().ToString());
                    //}
                    //catch
                    //{
                    //    model.PhotoUrl = "/Content/html5imageupload_assets/images/default-avatar.png";
                    //}

                    ctx.Instructor.Add(model);
                    ctx.Save();

                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                throw;
                return View();
            }
        }

        // GET: Instructors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Instructor.GetById<InstructorsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Instructors/Edit/5
        [HttpPost]
        public ActionResult Edit(InstructorsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Instructor.Update(model);
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

        // POST: Instructors/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var model = ctx.Instructor.GetById<InstructorsModel>(id.Value);
                if (model == null)
                {
                    return HttpNotFound();
                }

                ctx.Instructor.Delete(id.Value);
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
