//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FishermanSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fishing_Session
    {
        public int register_id { get; set; }
        public Nullable<System.DateTime> date_of_fishing_session { get; set; }
        public Nullable<int> amount_fished_kg { get; set; }
        public Nullable<int> duration_of_fishing_session_min { get; set; }
    
        public virtual User User { get; set; }
    }
}
