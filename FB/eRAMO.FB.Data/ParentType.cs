//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eRAMO.FB.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParentType : IParentType 
    {
        public ParentType() 
        {
            this.Questions = new HashSet<Question>();
        }
    
     
        [System.ComponentModel.DataAnnotations.Key]
        public int ParentTypeID { get; set; }
     
        public string Name { get; set; }
    
        public virtual ICollection<Question> Questions { get; set; }
    }
}
