﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LabMangementEntities : DbContext
    {
        public LabMangementEntities()
            : base("name=LabMangementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ListOfWork> ListOfWorks { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Work> Works { get; set; }
    }
}
