﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practice30
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HumanResourseEntities : DbContext
    {
        public HumanResourseEntities()
            : base("name=HumanResourseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<countries> countries { get; set; }
        public virtual DbSet<departments> departments { get; set; }
        public virtual DbSet<dependents> dependents { get; set; }
        public virtual DbSet<employees> employees { get; set; }
        public virtual DbSet<jobs> jobs { get; set; }
        public virtual DbSet<locations> locations { get; set; }
        public virtual DbSet<regions> regions { get; set; }
    
        public virtual ObjectResult<DEMO_PROC_Result> DEMO_PROC(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DEMO_PROC_Result>("DEMO_PROC", iDParameter);
        }
    }
}