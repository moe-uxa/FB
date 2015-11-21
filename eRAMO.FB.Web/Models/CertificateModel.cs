using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRAMO.FB.Manager;

namespace eRAMO.FB.Web.Models
{
    public class CertificateModel : LayoutModel
    {
        public int CertificateId { get; set; }
        public string Name { get; set; }
        public string ProgramOverview { get; set; }

        public string Objective { get; set; }

        public string ProgramTopics { get; set; }

        public string Charterholders { get; set; }
        public string Candidates { get; set; }
        public string Duration { get; set; }
        public string Time { get; set; }

        public List<InstructorModel> Instructors { get; set; }

        public CertificateModel()
        {
            GetAllCertificateMenu();
        }

        public CertificateModel GetCertificate(int certificateId)
        {
            var _ctx = new UnitOfWork();
            var result =
                _ctx.Certificate.GetAll<Model.CertificatesModel>()
                    .Where(certificate => certificate.CertificateID == certificateId)
                    .Select(item => new CertificateModel
                    {
                        Name = item.Name,
                        ProgramOverview = item.ProgramOverview,
                        Objective = item.Objective,
                        ProgramTopics = item.ProgramTopics,
                        Candidates = item.Candidates,
                        Duration = item.Duration,
                        Time = item.Time
                    }).FirstOrDefault();
            return result;
        }

        public List<InstructorModel> GetAllInstructors(int id)
        {
            var ctx = new UnitOfWork();
            Instructors = ctx.Certificate.GetAll<Model.CertificatesModel>()
                   .Where(certificate => certificate.CertificateID == id).Select(itm => itm.InstructorCollection).FirstOrDefault().Select(item => new InstructorModel()
           {
               Name = item.Name,
               PhotoUrl = item.PhotoUrl,
               Position = item.Position,
               Summary = item.Summary
           }).ToList();

            return Instructors;
        }
    }
}