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
    
    public partial class Level : ILevel 
    {
        public Level() 
        {
            this.Subjects = new HashSet<Subject>();
        }
    
        [System.ComponentModel.DataAnnotations.Key]
        public int LevelID { get; set; }
        public Nullable<int> CertificateID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    
        public virtual Certificate Certificate { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
