﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XIVMarketBoard_Api.Data;

#nullable disable

namespace XIVMarketBoard_Api.Migrations
{
    [DbContext(typeof(XivDbContext))]
    [Migration("20220612224632_AddedMarketableToItem")]
    partial class AddedMarketableToItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.DataCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DataCenters");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("CanBeCrafted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("IsMarketable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserName");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.MbPost", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("HighQuality")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastReviewDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int?>("RetainerId")
                        .HasColumnType("int");

                    b.Property<string>("RetainerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SellerId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("double");

                    b.Property<int?>("UniversalisEntryId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RetainerId");

                    b.HasIndex("UniversalisEntryId");

                    b.HasIndex("UserName");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AmountResult")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("jobId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("jobId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Retainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("WorldId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserName");

                    b.HasIndex("WorldId");

                    b.ToTable("Retainers");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.SaleHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("HighQuality")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.Property<int?>("UniversalisEntryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversalisEntryId");

                    b.ToTable("SaleHistory");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.UniversalisEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AveragePrice")
                        .HasColumnType("double");

                    b.Property<double>("AveragePriceHQ")
                        .HasColumnType("double");

                    b.Property<double>("AveragePriceNQ")
                        .HasColumnType("double");

                    b.Property<double>("CurrentAveragePrice")
                        .HasColumnType("double");

                    b.Property<double>("CurrentAveragePriceHQ")
                        .HasColumnType("double");

                    b.Property<double>("CurrentAveragePrinceNQ")
                        .HasColumnType("double");

                    b.Property<double>("HqSaleVelocity")
                        .HasColumnType("double");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUploadDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("MaxPrice")
                        .HasColumnType("double");

                    b.Property<double>("MaxPriceHQ")
                        .HasColumnType("double");

                    b.Property<double>("MaxPriceNQ")
                        .HasColumnType("double");

                    b.Property<double>("MinPrice")
                        .HasColumnType("double");

                    b.Property<double>("MinPriceHQ")
                        .HasColumnType("double");

                    b.Property<double>("MinPriceNQ")
                        .HasColumnType("double");

                    b.Property<double>("NqSaleVelocity")
                        .HasColumnType("double");

                    b.Property<DateTime>("QueryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("RegularSaleVelocity")
                        .HasColumnType("double");

                    b.Property<int>("WorldId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("WorldId");

                    b.ToTable("UniversalisEntries");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CharacterName")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.World", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DataCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DataCenterId");

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Ingredient", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XIVMarketBoard_Api.Entities.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Job", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.User", null)
                        .WithMany("Jobs")
                        .HasForeignKey("UserName");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.MbPost", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.Retainer", "Retainer")
                        .WithMany()
                        .HasForeignKey("RetainerId");

                    b.HasOne("XIVMarketBoard_Api.Entities.UniversalisEntry", null)
                        .WithMany("Posts")
                        .HasForeignKey("UniversalisEntryId");

                    b.HasOne("XIVMarketBoard_Api.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserName");

                    b.Navigation("Retainer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Recipe", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XIVMarketBoard_Api.Entities.Job", "job")
                        .WithMany()
                        .HasForeignKey("jobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("job");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Retainer", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XIVMarketBoard_Api.Entities.World", "World")
                        .WithMany()
                        .HasForeignKey("WorldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("World");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.SaleHistory", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.UniversalisEntry", null)
                        .WithMany("SaleHistory")
                        .HasForeignKey("UniversalisEntryId");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.UniversalisEntry", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XIVMarketBoard_Api.Entities.World", "World")
                        .WithMany()
                        .HasForeignKey("WorldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("World");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.World", b =>
                {
                    b.HasOne("XIVMarketBoard_Api.Entities.DataCenter", "DataCenter")
                        .WithMany()
                        .HasForeignKey("DataCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataCenter");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.Recipe", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.UniversalisEntry", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("SaleHistory");
                });

            modelBuilder.Entity("XIVMarketBoard_Api.Entities.User", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
