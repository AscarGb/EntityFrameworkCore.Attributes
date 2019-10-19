﻿// <auto-generated />
using System;
using EntityFrameworkCore.Example;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCore.Example.Data.Migrations.DbContextMigration
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20191019163228_DbContextMigration")]
    partial class DbContextMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkCore.Example.UsersData", b =>
                {
                    b.Property<string>("DataId");

                    b.Property<Guid>("UserId");

                    b.HasKey("DataId", "UserId");

                    b.ToTable("Data");
                });
#pragma warning restore 612, 618
        }
    }
}
