using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eRAMO.FB.Model;
using eRAMO.FB.Business;
using eRAMO.FB.Manager;
using eRAMO.FB.Data;
using System.IO;

namespace eRAMO.FB.Administrator.Controllers
{
    public class QuestionsController : Controller
    {

        UnitOfWork ctx = new UnitOfWork();

        // GET: Questions
        public ActionResult Index()
        {
            var list = ctx.Questions.GetAll<QuestionsModel>();
            return View(list);
        }

        // GET: Questions/Create
        public ActionResult Create()
        {
            QuestionsModel model = new QuestionsModel();
            model.QuestionOptions = new List<string>();
            return View(model);
        }

        // POST: Questions/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(QuestionsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Question newQuestion = new Question();

                    if (model.SubCategoryID != null)
                    {
                        newQuestion.ParentTypeID = (int)ParentTypes.SubCategory;
                        newQuestion.ParentID = model.SubCategoryID;
                    }
                    else if (model.ReadingID != null)
                    {
                        newQuestion.ParentTypeID = (int)ParentTypes.Reading;
                        newQuestion.ParentID = model.ReadingID;
                    }
                    else if (model.StudySessionID != null)
                    {
                        newQuestion.ParentTypeID = (int)ParentTypes.StudySession;
                        newQuestion.ParentID = model.StudySessionID;
                    }
                    else
                    {
                        ModelState.AddModelError("Parent", "Please select valid parent");
                        return View(model);
                    }

                    if (model.QuestionInformationStatus == "new")
                    {
                        QuestionInforamtion newQuestionInforamtion = new QuestionInforamtion()
                        {
                            CertificateID = model.CertificateID,
                            Text = model.QuestionInformation
                        };
                        ctx.QuestionInforamtions.Add(newQuestionInforamtion);

                        newQuestion.QuestionInformationID = newQuestionInforamtion.QuestionInformationID;
                    }
                    else if (model.QuestionInformationStatus == "existing")
                    {
                        newQuestion.QuestionInformationID = model.QuestionInformationID;
                    }


                    newQuestion.Text = model.Text;
                    newQuestion.Justification = model.Justification;
                    newQuestion.ExpectedDuration = model.ExpectedDuration;
                    newQuestion.Weight = model.Weight;
                    newQuestion.QuestionPoolID = model.QuestionPoolID;
                    newQuestion.Notes = model.Notes;

                    Question addedItem = ctx.Questions.Add(newQuestion);

                    foreach (var item in model.QuestionOptions)
                    {
                        addedItem.QuestionOptions.Add(new QuestionOption() { Text = item, IsAnswer = (model.QuestionAnswer == item) });
                    }

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

        // GET: Questions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = ctx.Questions.GetById<QuestionsModel>(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Questions/Edit/5
        [HttpPost]
        public ActionResult Edit(QuestionsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Questions.Update(model);
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

        // POST: Questions/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var model = ctx.Questions.GetById<QuestionsModel>(id.Value);
                if (model == null)
                {
                    return HttpNotFound();
                }

                ctx.Questions.Delete(id.Value);
                ctx.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetLevelsByCertificateID(string CertificateID)
        {
            if (String.IsNullOrEmpty(CertificateID))
            {
                throw new ArgumentNullException("CertificateID");
            }
            int id = 0;
            bool isValid = Int32.TryParse(CertificateID, out id);
            var Levels = ctx.Levels.GetAll().Where(c => c.CertificateID == id);
            var result = (from s in Levels
                          select new
                          {
                              id = s.LevelID.ToString(),
                              name = s.Name
                          }).ToList();
            result.Insert(0, new
            {
                id = string.Empty,
                name = "Select.."
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetSubjectsByLevelID(string LevelID)
        {
            if (String.IsNullOrEmpty(LevelID))
            {
                throw new ArgumentNullException("LevelID");
            }
            int id = 0;
            bool isValid = Int32.TryParse(LevelID, out id);
            var subLevels = ctx.Subjects.GetAll().Where(c => c.LevelID == id);
            var result = (from s in subLevels
                          select new
                          {
                              id = s.SubjectID.ToString(),
                              name = s.Name
                          }).ToList();
            result.Insert(0, new
            {
                id = string.Empty,
                name = "Select.."
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetStudySessionsBySubjectID(string SubjectID)
        {
            if (String.IsNullOrEmpty(SubjectID))
            {
                throw new ArgumentNullException("SubjectID");
            }
            int id = 0;
            bool isValid = Int32.TryParse(SubjectID, out id);
            var subSubjects = ctx.StudySessions.GetAll().Where(c => c.SubjectID == id);
            var result = (from s in subSubjects
                          select new
                          {
                              id = s.StudySessionID.ToString(),
                              name = s.Name
                          }).ToList();

            result.Insert(0, new
            {
                id = string.Empty,
                name = "Select.."
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetReadingsByStudySessionID(string StudySessionID)
        {
            if (String.IsNullOrEmpty(StudySessionID))
            {
                throw new ArgumentNullException("StudySessionID");
            }
            int id = 0;
            bool isValid = Int32.TryParse(StudySessionID, out id);
            var subStudySessions = ctx.Readings.GetAll().Where(c => c.StudySessionID == id);
            var result = (from s in subStudySessions
                          select new
                          {
                              id = s.ReadingID.ToString(),
                              name = s.Name
                          }).ToList();
            result.Insert(0, new
            {
                id = string.Empty,
                name = "Select.."
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetSubCategoriesByReadingID(string ReadingID)
        {
            if (String.IsNullOrEmpty(ReadingID))
            {
                throw new ArgumentNullException("ReadingID");
            }
            int id = 0;
            bool isValid = Int32.TryParse(ReadingID, out id);
            var subReadings = ctx.SubCategories.GetAll().Where(c => c.ReadingID == id);
            var result = (from s in subReadings
                          select new
                          {
                              id = s.SubCategoryID.ToString(),
                              name = s.Name
                          }).ToList();
            result.Insert(0, new
            {
                id = string.Empty,
                name = "Select.."
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetQuestionInformationPiece(int QuestionInformationID)
        {
            return Json(ctx.QuestionInforamtions.GetById(QuestionInformationID).Text, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UploadImage()
        {
            string fileExtention = string.Empty;
            string fileName = string.Empty;
            string filePath = string.Empty;

            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];


                fileExtention = System.IO.Path.GetExtension(file.FileName);
                fileName = string.Format("{0}.{1}", Guid.NewGuid(), fileExtention);
                filePath = String.Format("{0}{1}", Server.MapPath("~/ImagesTemp/"), fileName);

                file.SaveAs(filePath);


            }
            return Json(new { Success = true, Message = "Uploaded Successfully", FileName = fileName });
        }
    }
}
