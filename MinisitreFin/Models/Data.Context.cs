﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MinistreFinEntitiesDB : DbContext
    {
        public MinistreFinEntitiesDB()
            : base("name=MinistreFinEntitiesDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Groupe_thematiqe> Groupe_thematiqe { get; set; }
        public virtual DbSet<Initiatives> Initiatives { get; set; }
        public virtual DbSet<Projet> Projet { get; set; }
        public virtual DbSet<Type_Activite> Type_Activite { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<Utilisateur_Evenement2> Utilisateur_Evenement2 { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Evenements> Evenements { get; set; }
        public virtual DbSet<Membre_group> Membre_group { get; set; }
        public virtual DbSet<groue_detail> groue_detail { get; set; }
        public virtual DbSet<Activites> Activites { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<compte_rendu> compte_rendu { get; set; }
    }
}
