﻿// <auto-generated />
using System;
using ExcellentProtectionTaskAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExcellentProtectionTaskAPI.Migrations
{
    [DbContext(typeof(Entites))]
    [Migration("20220807234210_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExcellentProtectionTaskAPI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Paid")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double?>("Rest")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("float");

                    b.Property<double?>("TotalPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("float")
                        .HasComputedColumnSql("Price * Quantity");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ExcellentProtectionTaskAPI.Models.OrderPayment", b =>
                {
                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 8, 8, 1, 42, 10, 9, DateTimeKind.Local).AddTicks(8171));

                    b.HasKey("PaymentId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersPayment");
                });

            modelBuilder.Entity("ExcellentProtectionTaskAPI.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("Ammount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 8, 8, 1, 42, 10, 9, DateTimeKind.Local).AddTicks(7572));

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("ExcellentProtectionTaskAPI.Models.OrderPayment", b =>
                {
                    b.HasOne("ExcellentProtectionTaskAPI.Models.Order", "order")
                        .WithMany("payments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ExcellentProtectionTaskAPI.Models.Payment", "payment")
                        .WithMany("orders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("order");

                    b.Navigation("payment");
                });

            modelBuilder.Entity("ExcellentProtectionTaskAPI.Models.Order", b =>
                {
                    b.Navigation("payments");
                });

            modelBuilder.Entity("ExcellentProtectionTaskAPI.Models.Payment", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
