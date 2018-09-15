﻿// <auto-generated />
using System;
using InternetProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternetProject.Server.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180704153432_colorcode")]
    partial class colorcode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternetProject.Models.Account", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CityID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("InternetProject.Models.Ad", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AdTime");

                    b.Property<string>("Address")
                        .HasMaxLength(300);

                    b.Property<double?>("AdvancedPayment");

                    b.Property<Guid>("CarID");

                    b.Property<Guid>("ColorID");

                    b.Property<string>("Description");

                    b.Property<bool>("Expired");

                    b.Property<bool>("FirstHanded");

                    b.Property<int?>("InstallmentsCount");

                    b.Property<double?>("InstallmentsPayment");

                    b.Property<bool>("Insurance");

                    b.Property<DateTime?>("InsuranceExpirationDate");

                    b.Property<double>("KM");

                    b.Property<double?>("Lat");

                    b.Property<double?>("Lng");

                    b.Property<DateTime>("ManufacturingDate");

                    b.Property<Guid>("OwnerID");

                    b.Property<bool>("PlanedPayment");

                    b.Property<double>("Price");

                    b.Property<bool>("TechnicalInspection");

                    b.Property<bool>("Verified");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.HasIndex("ColorID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Ads");
                });

            modelBuilder.Entity("InternetProject.Models.CarBrand", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("InternetProject.Models.CarColor", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Color")
                        .IsUnique();

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("InternetProject.Models.CarType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BrandID");

                    b.Property<int>("CarClass");

                    b.Property<string>("CarDescription");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("Fuel");

                    b.Property<int>("Gearbox");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("InternetProject.Models.Chats", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FromID");

                    b.Property<string>("FromName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("ToID");

                    b.HasKey("ID");

                    b.HasIndex("ToID");

                    b.HasIndex("FromID", "ToID")
                        .IsUnique();

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("InternetProject.Models.CityName", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("InternetProject.Models.Image", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AdID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("AdID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("InternetProject.Models.Account", b =>
                {
                    b.HasOne("InternetProject.Models.CityName", "City")
                        .WithMany("Advertisers")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetProject.Models.Ad", b =>
                {
                    b.HasOne("InternetProject.Models.CarType", "Car")
                        .WithMany("Ads")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetProject.Models.CarColor", "Color")
                        .WithMany("Ads")
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetProject.Models.Account", "Owner")
                        .WithMany("Ads")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetProject.Models.CarType", b =>
                {
                    b.HasOne("InternetProject.Models.CarBrand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetProject.Models.Chats", b =>
                {
                    b.HasOne("InternetProject.Models.Account", "To")
                        .WithMany("Chats")
                        .HasForeignKey("ToID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetProject.Models.Image", b =>
                {
                    b.HasOne("InternetProject.Models.Ad", "Ad")
                        .WithMany("Images")
                        .HasForeignKey("AdID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
