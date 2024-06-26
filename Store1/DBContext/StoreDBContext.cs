﻿using Microsoft.EntityFrameworkCore;
using Store1.Entity;
using Store1.Model;
using System.Data.Common;

namespace Store1.DBContext
{
    public class StoreDBContext:DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options):base(options)
        {
              
        }

        #region Table
        public virtual DbSet<Customer> Customer {  get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetail {  get; set; }
        public virtual DbSet<CustomerAdditionalDetail> CustomerAdditionalDetail {  get; set; }
        #endregion Table
        #region view and sp
        public virtual DbSet<FetchCustomerDetail> vw_getallcustomerdetail { get; set; }
        public virtual DbSet<FetchCustomerDetail> sp_customerdetail { get; set; }

        #endregion view and sp
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FetchCustomerDetail>().ToView("vw_getallcustomerdetail").HasNoKey();
            modelBuilder.Entity<FetchCustomerDetail>().ToView("sp_customerdetail").HasNoKey();
        }
    }
}
