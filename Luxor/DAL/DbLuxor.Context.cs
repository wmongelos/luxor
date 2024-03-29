﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Luxor.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbLuxorEntities : DbContext
    {
        public dbLuxorEntities()
            : base("name=dbLuxorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<Entidades_Bancarias> Entidades_Bancarias { get; set; }
        public virtual DbSet<Formas_Comunicacion> Formas_Comunicacion { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<Organismos> Organismos { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Usuarios_Roles> Usuarios_Roles { get; set; }
        public virtual DbSet<Medios_Pagos> Medios_Pagos { get; set; }
        public virtual DbSet<Clientes_Tipos> Clientes_Tipos { get; set; }
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Clientes_Actividades> Clientes_Actividades { get; set; }
        public virtual DbSet<Empleadores_Tipo> Empleadores_Tipo { get; set; }
        public virtual DbSet<Monotributo_Categorias> Monotributo_Categorias { get; set; }
        public virtual DbSet<Monotributo_Regimen> Monotributo_Regimen { get; set; }
        public virtual DbSet<RegimenGral_Categorias> RegimenGral_Categorias { get; set; }
        public virtual DbSet<Tareas_Estados> Tareas_Estados { get; set; }
        public virtual DbSet<Clientes_CtaCte> Clientes_CtaCte { get; set; }
        public virtual DbSet<Tareas> Tareas { get; set; }
        public virtual DbSet<Tareas_Principales> Tareas_Principales { get; set; }
        public virtual DbSet<Tareas_Periodos> Tareas_Periodos { get; set; }
        public virtual DbSet<Tareas_Secundarias> Tareas_Secundarias { get; set; }
        public virtual DbSet<Tareas_Tipos> Tareas_Tipos { get; set; }
        public virtual DbSet<Clientes_Tareas> Clientes_Tareas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Metodos_Facturacion> Metodos_Facturacion { get; set; }
    
        [DbFunction("dbLuxorEntities", "GetTareas")]
        public virtual IQueryable<GetTareas_Result> GetTareas(Nullable<int> id_tarea_principal, Nullable<int> id_tarea_secundaria, Nullable<int> id_tarea_tipo, Nullable<int> mes, Nullable<int> año)
        {
            var id_tarea_principalParameter = id_tarea_principal.HasValue ?
                new ObjectParameter("id_tarea_principal", id_tarea_principal) :
                new ObjectParameter("id_tarea_principal", typeof(int));
    
            var id_tarea_secundariaParameter = id_tarea_secundaria.HasValue ?
                new ObjectParameter("id_tarea_secundaria", id_tarea_secundaria) :
                new ObjectParameter("id_tarea_secundaria", typeof(int));
    
            var id_tarea_tipoParameter = id_tarea_tipo.HasValue ?
                new ObjectParameter("id_tarea_tipo", id_tarea_tipo) :
                new ObjectParameter("id_tarea_tipo", typeof(int));
    
            var mesParameter = mes.HasValue ?
                new ObjectParameter("mes", mes) :
                new ObjectParameter("mes", typeof(int));
    
            var añoParameter = año.HasValue ?
                new ObjectParameter("año", año) :
                new ObjectParameter("año", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetTareas_Result>("[dbLuxorEntities].[GetTareas](@id_tarea_principal, @id_tarea_secundaria, @id_tarea_tipo, @mes, @año)", id_tarea_principalParameter, id_tarea_secundariaParameter, id_tarea_tipoParameter, mesParameter, añoParameter);
        }
    }
}
