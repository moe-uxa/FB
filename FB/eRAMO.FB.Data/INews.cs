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
    
    public interface INews
    {
        int NewsID { get; set; }
        string Text { get; set; }
        string BannarPhoto { get; set; }
        string Icon { get; set; }
        string Title { get; set; }
        Nullable<System.DateTime> date { get; set; }
    
    }
}
