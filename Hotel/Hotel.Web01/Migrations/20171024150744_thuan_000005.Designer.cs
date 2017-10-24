﻿// <auto-generated />
using Hotel.Common;
using Hotel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Hotel.Web01.Migrations
{
    [DbContext(typeof(InstanceEntities))]
    [Migration("20171024150744_thuan_000005")]
    partial class thuan_000005
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .HasMaxLength(256);

                    b.Property<int?>("CompanyId");

                    b.Property<int?>("CoverImageId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Html")
                        .HasMaxLength(2147483647);

                    b.Property<bool?>("IsHidden");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(2147483647);

                    b.Property<string>("Slug")
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CoverImageId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Hotel.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Adults");

                    b.Property<DateTime?>("CheckInDate");

                    b.Property<DateTime?>("CheckOutDate");

                    b.Property<int?>("Children");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<string>("Phone")
                        .HasMaxLength(256);

                    b.Property<int?>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Hotel.Entities.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimName")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("Hotel.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyCode")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ExpiredDate");

                    b.Property<bool?>("IsActive");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Hotel.Entities.CompanyInfo", b =>
                {
                    b.Property<int>("CompanyId");

                    b.Property<string>("Address1")
                        .HasMaxLength(512);

                    b.Property<string>("Address2")
                        .HasMaxLength(512);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(256);

                    b.Property<string>("Email1")
                        .HasMaxLength(512);

                    b.Property<string>("Email2")
                        .HasMaxLength(512);

                    b.Property<string>("Facebook")
                        .HasMaxLength(512);

                    b.Property<string>("GooglePlus")
                        .HasMaxLength(512);

                    b.Property<int?>("LogoImageId");

                    b.Property<string>("LongDescription")
                        .HasMaxLength(2147483647);

                    b.Property<float?>("MapLatitude");

                    b.Property<float?>("MapLongitude");

                    b.Property<string>("Phone1")
                        .HasMaxLength(512);

                    b.Property<string>("Phone2")
                        .HasMaxLength(512);

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(2147483647);

                    b.Property<string>("Skype")
                        .HasMaxLength(512);

                    b.Property<string>("Twitter")
                        .HasMaxLength(512);

                    b.Property<string>("YouTube")
                        .HasMaxLength(512);

                    b.HasKey("CompanyId");

                    b.HasIndex("LogoImageId");

                    b.ToTable("CompanyInfo");
                });

            modelBuilder.Entity("Hotel.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("S3FileKey")
                        .HasMaxLength(250);

                    b.Property<string>("Url")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Hotel.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(2147483647);

                    b.Property<int?>("ImageId");

                    b.Property<bool?>("IsHidden");

                    b.Property<int?>("Priority");

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ImageId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Hotel.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<int>("RoleType");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Hotel.Entities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClaimId");

                    b.Property<int?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Hotel.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<int?>("CoverImageId");

                    b.Property<string>("Description")
                        .HasMaxLength(2147483647);

                    b.Property<string>("FeaturesJson")
                        .HasMaxLength(2147483647);

                    b.Property<bool?>("IsHidden");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<double?>("Price");

                    b.Property<int?>("Priority");

                    b.Property<string>("Slug")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CoverImageId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Hotel.Entities.RoomImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ImageId");

                    b.Property<int?>("Priority");

                    b.Property<int?>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomImage");
                });

            modelBuilder.Entity("Hotel.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<int?>("CoverImageId");

                    b.Property<string>("Html")
                        .HasMaxLength(2147483647);

                    b.Property<bool?>("IsHidden");

                    b.Property<int?>("Priority");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(2147483647);

                    b.Property<string>("Slug")
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CoverImageId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Hotel.Entities.TopSlide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<int?>("ImageId");

                    b.Property<bool?>("IsHidden");

                    b.Property<int?>("Priority");

                    b.Property<string>("Text1")
                        .HasMaxLength(256);

                    b.Property<string>("Text2")
                        .HasMaxLength(256);

                    b.Property<string>("Text3")
                        .HasMaxLength(256);

                    b.Property<string>("Url")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ImageId");

                    b.ToTable("TopSlide");
                });

            modelBuilder.Entity("Hotel.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("Password")
                        .HasMaxLength(250);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(250);

                    b.Property<string>("ProviderName")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(250);

                    b.Property<int?>("UserStatusId");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Hotel.Entities.UserFeedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Content")
                        .HasMaxLength(2147483647);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("Phone")
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("UserFeedback");
                });

            modelBuilder.Entity("Hotel.Entities.UserLoginToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiredDated");

                    b.Property<bool?>("IsRememberMe");

                    b.Property<DateTime>("LastLoginDated");

                    b.Property<string>("Token")
                        .HasMaxLength(250);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLoginToken");
                });

            modelBuilder.Entity("Hotel.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(250);

                    b.Property<int?>("AvatarId");

                    b.Property<string>("City")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("FirstName")
                        .HasMaxLength(250);

                    b.Property<string>("LastName")
                        .HasMaxLength(250);

                    b.Property<int?>("UserId");

                    b.Property<bool?>("WasVerifiedEmail");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Hotel.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("RoleId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Hotel.Entities.Article", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithMany("Articles")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Entities.Image", "CoverImage")
                        .WithMany()
                        .HasForeignKey("CoverImageId");
                });

            modelBuilder.Entity("Hotel.Entities.Booking", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithMany("Bookings")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Entities.CompanyInfo", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithOne("CompanyInfo")
                        .HasForeignKey("Hotel.Entities.CompanyInfo", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Entities.Image", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoImageId");
                });

            modelBuilder.Entity("Hotel.Entities.Photo", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithMany("Photos")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Hotel.Entities.RoleClaim", b =>
                {
                    b.HasOne("Hotel.Entities.Claim", "Claim")
                        .WithMany("RoleClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Entities.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Entities.Room", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithMany("Rooms")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Entities.Image", "CoverImage")
                        .WithMany()
                        .HasForeignKey("CoverImageId");
                });

            modelBuilder.Entity("Hotel.Entities.RoomImage", b =>
                {
                    b.HasOne("Hotel.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("Hotel.Entities.Room", "Room")
                        .WithMany("RoomImages")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Entities.Service", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithMany("Services")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Entities.Image", "CoverImage")
                        .WithMany()
                        .HasForeignKey("CoverImageId");
                });

            modelBuilder.Entity("Hotel.Entities.TopSlide", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithMany("TopSlides")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Hotel.Entities.UserFeedback", b =>
                {
                    b.HasOne("Hotel.Entities.Company", "Company")
                        .WithMany("UserFeedbacks")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Entities.UserLoginToken", b =>
                {
                    b.HasOne("Hotel.Entities.User", "User")
                        .WithMany("UserLoginTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Entities.UserProfile", b =>
                {
                    b.HasOne("Hotel.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.HasOne("Hotel.Entities.User", "User")
                        .WithMany("UserProfiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Entities.UserRole", b =>
                {
                    b.HasOne("Hotel.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("Hotel.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
