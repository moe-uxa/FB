//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eRAMO.FB.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionInforamtion : IQuestionInforamtion 
    {
        public QuestionInforamtion() 
        {
            this.Questions = new HashSet<Question>();
        }
    
        [System.ComponentModel.DataAnnotations.Key]
        public int QuestionInformationID { get; set; }
        public Nullable<int> CertificateID { get; set; }
        public string Text { get; set; }
    
        public virtual ICollection<Question> Questions { get; set; }
        public virtual Certificate Certificate { get; set; }
    }
}
