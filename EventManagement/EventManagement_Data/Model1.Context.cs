﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventManagement_Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EventManagementSystemEntities : DbContext
    {
        public EventManagementSystemEntities()
            : base("name=EventManagementSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admindetail> admindetails { get; set; }
        public virtual DbSet<bookvenue> bookvenues { get; set; }
        public virtual DbSet<userregistration> userregistrations { get; set; }
    }
}
