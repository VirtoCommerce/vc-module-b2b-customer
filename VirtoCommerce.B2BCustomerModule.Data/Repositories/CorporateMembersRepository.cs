﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using VirtoCommerce.B2BCustomerModule.Data.Model;
using VirtoCommerce.CustomerModule.Data.Repositories;
using VirtoCommerce.Platform.Data.Infrastructure.Interceptors;

namespace VirtoCommerce.B2BCustomerModule.Data.Repositories
{
    public class CorporateMembersRepository : CustomerRepositoryImpl, ICorporateMembersRepository
    {
        public CorporateMembersRepository()
        {
        }

        public CorporateMembersRepository(string nameOrConnectionString, params IInterceptor[] interceptors)
            : base(nameOrConnectionString, interceptors)
        {
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyDataEntity>().HasKey(x => x.Id).Property(x => x.Id);
            modelBuilder.Entity<CompanyDataEntity>().Property(x => x.Name).HasColumnAnnotation("Name", new IndexAnnotation(new IndexAttribute { IsUnique = true }));
            modelBuilder.Entity<CompanyDataEntity>().ToTable("Company");

            modelBuilder.Entity<CompanyMemberDataEntity>().HasKey(x => x.Id).Property(x => x.Id);
            modelBuilder.Entity<CompanyMemberDataEntity>().Property(x => x.Name).HasColumnAnnotation("Name", new IndexAnnotation(new IndexAttribute { IsUnique = true }));
            modelBuilder.Entity<CompanyMemberDataEntity>().ToTable("CompanyMember");

            modelBuilder.Entity<DepartmentDataEntity>().HasKey(x => x.Id).Property(x => x.Id);
            modelBuilder.Entity<DepartmentDataEntity>().ToTable("Department");

            base.OnModelCreating(modelBuilder);
        }

        public IQueryable<DepartmentDataEntity> Departments => GetAsQueryable<DepartmentDataEntity>();
    }
}