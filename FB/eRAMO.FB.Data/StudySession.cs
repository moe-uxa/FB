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
    
    public partial class StudySession : IStudySession 
    {
        public StudySession() 
        {
            this.Readings = new HashSet<Reading>();
        }
    
        [System.ComponentModel.DataAnnotations.Key]
        public int StudySessionID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    
        public virtual ICollection<Reading> Readings { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
