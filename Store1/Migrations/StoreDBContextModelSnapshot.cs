﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store1.DBContext;

#nullable disable

namespace Store1.Migrations
{
    [DbContext(typeof(StoreDBContext))]
    partial class StoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Store1.Entity.FetchCustomerDetail", b =>
                {
                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FatherName")
                        .HasColumnType("longtext");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<long?>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("city")
                        .HasColumnType("longtext");

                    b.Property<string>("country")
                        .HasColumnType("longtext");

                    b.ToTable((string)null);

                    b.ToView("vw_getallcustomerdetail", (string)null);
                });

            modelBuilder.Entity("Store1.Model.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Store1.Model.CustomerAdditionalDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("CustomerAdditionalDetail");
                });

            modelBuilder.Entity("Store1.Model.CustomerDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("CustomerDetail");
                });

            modelBuilder.Entity("Store1.Model.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("ExpiryDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ManufacturedDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Store1.Model.CustomerAdditionalDetail", b =>
                {
                    b.HasOne("Store1.Model.Customer", "Customer")
                        .WithOne("AdditionalDetails")
                        .HasForeignKey("Store1.Model.CustomerAdditionalDetail", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Store1.Model.CustomerDetail", b =>
                {
                    b.HasOne("Store1.Model.Customer", "Customer")
                        .WithOne("Details")
                        .HasForeignKey("Store1.Model.CustomerDetail", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Store1.Model.OrderItem", b =>
                {
                    b.HasOne("Store1.Model.Customer", "Customer")
                        .WithOne("OrderItems")
                        .HasForeignKey("Store1.Model.OrderItem", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Store1.Model.Customer", b =>
                {
                    b.Navigation("AdditionalDetails")
                        .IsRequired();

                    b.Navigation("Details")
                        .IsRequired();

                    b.Navigation("OrderItems")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
