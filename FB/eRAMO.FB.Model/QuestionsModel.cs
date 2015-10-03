using eRAMO.FB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRAMO.FB.Model
{
    public class QuestionsModel : IQuestion
    {
        [Key]
        public int QuestionID { get; set; }

        [Display(Name = "Information Piece")]
        public int? QuestionInformationID { get; set; }

        [Display(Name = "Information Piece")]
        public string QuestionInformation { get; set; }

        [Display(Name = "Question Text")]
        [Required]
        public string Text { get; set; }

        [Display(Name = "Options")]
        public int? QuestionOptionID { get; set; }

        [Display(Name = "Justification")]
        public string Justification { get; set; }

        [Display(Name = "Expected Answer Duration")]
        [Required]
        public double? ExpectedDuration { get; set; }

        [Display(Name = "Question Weight")]
        [Required]
        public int? Weight { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        public int? ParentID { get; set; }

        public int? ParentTypeID { get; set; }

        [Display(Name = "Question Pool")]
        [Required]
        public int? QuestionPoolID { get; set; }

        [Display(Name = "Sub-Category")]
        public int? SubCategoryID { get; set; }

        [Display(Name = "Reading")]
        public int? ReadingID { get; set; }

        [Display(Name = "Study Session")]
        [Required]
        public int? StudySessionID { get; set; }

        [Display(Name = "Subject")]
        [Required]
        public int? SubjectID { get; set; }

        [Display(Name = "Level")]
        [Required]
        public int? LevelID { get; set; }

        [Display(Name = "Certificate")]
        [Required]
        public int? CertificateID { get; set; }

        [Display(Name = "Question Options")]
        [Required]
        public List<string> QuestionOptions { get; set; }

        [Display(Name = "Question Answer")]
        [Required]
        public string QuestionAnswer { get; set; }

      
        public string QuestionInformationStatus { get; set; }

    }
}
