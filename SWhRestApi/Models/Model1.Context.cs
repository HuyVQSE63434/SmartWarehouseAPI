﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWhRestApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SWHDatabaseEntities : DbContext
    {
        public SWHDatabaseEntities()
            : base("name=SWHDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<check_store> check_store { get; set; }
        public virtual DbSet<check_store_detail> check_store_detail { get; set; }
        public virtual DbSet<material> materials { get; set; }
        public virtual DbSet<material_type> material_type { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<store_material> store_material { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transaction> transactions { get; set; }
        public virtual DbSet<transaction_detail> transaction_detail { get; set; }
        public virtual DbSet<transaction_type> transaction_type { get; set; }
    }
}
