//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVPMigrator.Old
{
    using System;
    using System.Collections.Generic;
    
    public partial class manualprofile
    {
        public int id { get; set; }
        public int profile_id { get; set; }
    
        public virtual profile profile { get; set; }
    }
}
