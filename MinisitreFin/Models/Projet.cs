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
    
    public partial class Projet
    {
        public int ID { get; set; }
        public int ID_Initiative { get; set; }
        public string Nom_projet { get; set; }
        public string Description { get; set; }
        public string Objectif_projet { get; set; }
        public Nullable<System.DateTime> Date_debut { get; set; }
        public Nullable<System.DateTime> Date_fin { get; set; }
    
        public virtual Initiatives Initiatives { get; set; }
    }
}
