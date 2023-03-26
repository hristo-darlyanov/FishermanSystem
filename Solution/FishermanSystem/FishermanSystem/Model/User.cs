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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Boat = new HashSet<Boat>();
        }

        public User(string username, string password, int hobby)
        {
            this.username = username;
            this.password = password;
            this.hobby = hobby;
        }

        public int register_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int hobby { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boat> Boat { get; set; }
        public virtual Fishing_Session Fishing_Session { get; set; }
    }
}
