﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionPuntoDeVenta
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PescaditoDBEntities : DbContext
    {
        public PescaditoDBEntities()
            : base("name=PescaditoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<InvCantidadPorTaco> InvCantidadPorTacoes { get; set; }
        public DbSet<InvInventario> InvInventarios { get; set; }
        public DbSet<InvProducto> InvProductos { get; set; }
        public DbSet<InvUnidadMed> InvUnidadMeds { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersType> UsersTypes { get; set; }
    }
}