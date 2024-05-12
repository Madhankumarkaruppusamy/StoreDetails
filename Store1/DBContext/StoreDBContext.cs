﻿using Microsoft.EntityFrameworkCore;
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
    }
}
