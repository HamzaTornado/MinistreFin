//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinisitreFin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activites
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activites()
        {
            this.compte_rendu = new HashSet<compte_rendu>();
        }
    
        public int ID { get; set; }
        public int Type_ActiviteID { get; set; }
        public string Nom_activ { get; set; }
        public Nullable<int> AgendaID { get; set; }
        public string Objectif_activ { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<bool> statu { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Emplacement { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compte_rendu> compte_rendu { get; set; }
        public virtual Agenda Agenda { get; set; }
        public virtual Type_Activite Type_Activite { get; set; }
    }
}
