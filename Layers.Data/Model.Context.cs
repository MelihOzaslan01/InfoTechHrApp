﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Layers.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbInfoTechHrAppEntities : DbContext
    {
        public DbInfoTechHrAppEntities()
            : base("name=DbInfoTechHrAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SysBolum> SysBolum { get; set; }
        public virtual DbSet<SysDepartman> SysDepartman { get; set; }
        public virtual DbSet<SysOkul> SysOkul { get; set; }
        public virtual DbSet<TblIzinTalep> TblIzinTalep { get; set; }
        public virtual DbSet<TblKisi> TblKisi { get; set; }
        public virtual DbSet<TblKisiAdres> TblKisiAdres { get; set; }
        public virtual DbSet<TblKisiEgitim> TblKisiEgitim { get; set; }
        public virtual DbSet<TblKisiTelefon> TblKisiTelefon { get; set; }
        public virtual DbSet<TblKullanici> TblKullanici { get; set; }
        public virtual DbSet<TblPdks> TblPdks { get; set; }
    }
}
