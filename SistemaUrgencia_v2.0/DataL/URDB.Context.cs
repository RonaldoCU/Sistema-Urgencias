﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaUrgencia_v2._0.DataL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBUrgenciasEntities : DbContext
    {
        public DBUrgenciasEntities()
            : base("name=DBUrgenciasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Analisis> Analisis { get; set; }
        public virtual DbSet<ConstantesVitales> ConstantesVitales { get; set; }
        public virtual DbSet<DarCamas> DarCamas { get; set; }
        public virtual DbSet<DatosUrgencia> DatosUrgencia { get; set; }
        public virtual DbSet<Imagenes> Imagenes { get; set; }
        public virtual DbSet<Ingresos> Ingresos { get; set; }
        public virtual DbSet<Perdida_liquidos> Perdida_liquidos { get; set; }
        public virtual DbSet<Prescripcion_Emergencia> Prescripcion_Emergencia { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<TipoPrescripcion> TipoPrescripcion { get; set; }
        public virtual DbSet<Valoracion_inicial> Valoracion_inicial { get; set; }
    }
}
