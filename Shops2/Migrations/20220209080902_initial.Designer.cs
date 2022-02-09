﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Shops2.Data;

namespace Shops2.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220209080902_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Shops2.Model.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<string>("contactPhone")
                        .HasColumnType("text");

                    b.Property<int>("phoneId")
                        .HasColumnType("integer");

                    b.Property<string>("user")
                        .HasColumnType("text");

                    b.HasKey("orderId");

                    b.ToTable("companie");
                });

            modelBuilder.Entity("Shops2.Model.Phone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("company")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("phone");
                });
#pragma warning restore 612, 618
        }
    }
}