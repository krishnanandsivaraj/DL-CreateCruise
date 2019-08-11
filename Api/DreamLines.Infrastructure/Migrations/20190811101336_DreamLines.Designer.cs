﻿// <auto-generated />
using System;
using DreamLines.Infrastructure.Data.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DreamLines.Infrastructure.Migrations
{
    [DbContext(typeof(CruiseContext))]
    [Migration("20190811101336_DreamLines")]
    partial class DreamLines
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DreamLines.Core.Domain.Entities.Cabintype", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("company_id");

                    b.Property<int>("nid");

                    b.Property<int>("ship_id");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("cabinTypes");
                });

            modelBuilder.Entity("DreamLines.Core.Domain.Entities.Cruise", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cabinType");

                    b.Property<DateTime>("departureDate");

                    b.Property<bool>("isFlight");

                    b.Property<int>("nid");

                    b.Property<int>("rId");

                    b.Property<int>("shipId");

                    b.HasKey("id");

                    b.ToTable("cruise");
                });

            modelBuilder.Entity("DreamLines.Core.Domain.Entities.CruiseLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("nid");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.ToTable("cruiseLines");
                });

            modelBuilder.Entity("DreamLines.Core.Domain.Entities.Port", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("country");

                    b.Property<string>("country_code");

                    b.Property<int>("nid");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("ports");
                });

            modelBuilder.Entity("DreamLines.Core.Domain.Entities.Ship", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("company_id");

                    b.Property<int>("ship_id");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("ships");
                });
#pragma warning restore 612, 618
        }
    }
}
