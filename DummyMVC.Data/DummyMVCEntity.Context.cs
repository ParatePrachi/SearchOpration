﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DummyMVC.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mvcdemoEntities : DbContext
    {
        public mvcdemoEntities()
            : base("name=mvcdemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblHospital> tblHospitals { get; set; }
        public virtual DbSet<tblstudent> tblstudents { get; set; }
        public virtual DbSet<tblSearch> tblSearches { get; set; }
        public virtual DbSet<tblBooking> tblBookings { get; set; }
        public virtual DbSet<tbldemo> tbldemoes { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblservice> tblservices { get; set; }
        public virtual DbSet<tblFile> tblFiles { get; set; }
    }
}
