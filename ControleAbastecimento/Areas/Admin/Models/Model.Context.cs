﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControleAbastecimento.Areas.Admin.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDAbastecimentoEntities1 : DbContext
    {
        public BDAbastecimentoEntities1()
            : base("name=BDAbastecimentoEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CadUsuario> CadUsuario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<CadMotorista> CadMotorista { get; set; }
        public virtual DbSet<CadPosto> CadPosto { get; set; }
        public virtual DbSet<CadVeiculo> CadVeiculo { get; set; }
    }
}