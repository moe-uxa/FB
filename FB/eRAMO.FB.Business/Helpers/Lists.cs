using eRAMO.FB.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace eRAMO.FB.Business
{
    public class Lists
    {
        //Uncomment this code after creating UnitOfWork Repository
        readonly static UnitOfWork ctx = new UnitOfWork();

        private static IEnumerable<SelectListItem> GetSelectList(Dictionary<int, string> list)
        {
            var obj = new SelectListItem
            {
                Value = string.Empty,
                Text = "Select..",
                Selected = true,
            };

            yield return obj;

            foreach (var item in list)
            {
                obj = new SelectListItem { Value = item.Key.ToString(), Text = item.Value };
                yield return obj;
            }
        }

        public static IEnumerable<SelectListItem> GetCertificates()
        {
            return GetSelectList(ctx.Certificates.GetAll().ToDictionary(c => c.CertificateID, c => c.Name));
        }

        public static IEnumerable<SelectListItem> GetLevels()
        {
            return GetSelectList(ctx.Levels.GetAll().ToDictionary(c => c.LevelID, c => c.Name));
        }


        public static IEnumerable<SelectListItem> GetSubjects()
        {
            return GetSelectList(ctx.Subjects.GetAll().ToDictionary(c => c.SubjectID, c => c.Name));
        }


        public static IEnumerable<SelectListItem> GetStudySessions()
        {
            return GetSelectList(ctx.StudySessions.GetAll().ToDictionary(c => c.StudySessionID, c => c.Name));
        }


        public static IEnumerable<SelectListItem> GetReadings()
        {
            return GetSelectList(ctx.Readings.GetAll().ToDictionary(c => c.ReadingID, c => c.Name));
        }


        public static IEnumerable<SelectListItem> GetSubCategories()
        {
            return GetSelectList(ctx.SubCategories.GetAll().ToDictionary(c => c.SubCategoryID, c => c.Name));
        }

        public static IEnumerable<SelectListItem> GetQuestionInformations()
        {
            return GetSelectList(ctx.QuestionInforamtions.GetAll().ToDictionary(c => c.QuestionInformationID, c => ScrubHtml(c.Text.Substring(0, c.Text.Length > 50 ? 50 : c.Text.Length))));
        }

        public static IEnumerable<SelectListItem> GetQuestionPools()
        {
            return GetSelectList(ctx.QuestionPools.GetAll().ToDictionary(c => c.QuestionPoolID, c => c.Name));
        }


        public static string ScrubHtml(string value)
        {
            var step1 = Regex.Replace(value, @"<[^>]+>|&nbsp;", "").Trim();
            var step2 = Regex.Replace(step1, @"\s{2,}", " ");
            return step2;
        }
    }
}
