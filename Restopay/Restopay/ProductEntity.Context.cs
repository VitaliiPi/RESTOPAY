﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restopay
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProductsDatabaseEntities : DbContext
    {
        public ProductsDatabaseEntities()
            : base("name=ProductsDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<appetizer> appetizers { get; set; }
        public virtual DbSet<beverage> beverages { get; set; }
        public virtual DbSet<cart> carts { get; set; }
        public virtual DbSet<dessert> desserts { get; set; }
        public virtual DbSet<mainCourse> mainCourses { get; set; }
    }
}
