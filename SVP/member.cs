//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVP
{
    using System;
    using System.Collections.Generic;
    
    public partial class member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public member()
        {
            this.sequence = new HashSet<sequence>();
            this.award = new HashSet<award>();
            this.group = new HashSet<group>();
            this.participant = new HashSet<participant>();
        }
    
        public int id { get; set; }
        public string firstname { get; set; }
        public string name { get; set; }
        public System.DateTime birthday { get; set; }
        public int club_id { get; set; }
        public string shortname { get; set; }

        public override string ToString()
        {
            return name + ", " + firstname;
        }

        public virtual club club { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sequence> sequence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<award> award { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<group> group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participant> participant { get; set; }
    }
}
