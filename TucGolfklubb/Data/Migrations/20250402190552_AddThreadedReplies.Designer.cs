﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TucGolfklubb.Data;

#nullable disable

namespace TucGolfklubb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250402190552_AddThreadedReplies")]
    partial class AddThreadedReplies
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", "TucUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "TucUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "TucUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "TucUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "TucUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "TucUserMngt");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "TucUserMngt");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Klubbor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kläder"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Skor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Väskor"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tillbehör"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Bollar"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Träningsutrustning"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Elektronik"
                        });
                });

            modelBuilder.Entity("TucGolfklubb.Models.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Forums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Diskussioner om allt möjligt relaterat till golf",
                            Title = "Allmänt om golf"
                        });
                });

            modelBuilder.Entity("TucGolfklubb.Models.ForumPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("ForumPosts");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ForumReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForumPostId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentReplyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ForumPostId");

                    b.HasIndex("ParentReplyId");

                    b.HasIndex("UserId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TucGolfklubb.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Drivers",
                            Price = 3000.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Järnklubbor",
                            Price = 6000.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Wedges",
                            Price = 1500.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Putters",
                            Price = 2500.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Tröjor",
                            Price = 800.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Byxor och shorts",
                            Price = 1200.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Jackor",
                            Price = 1500.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Kepsar",
                            Price = 300.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Spikade skor",
                            Price = 1800.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Spikfria skor",
                            Price = 1800.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Stöd och dämpning",
                            Price = 1800.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Caddyväskor",
                            Price = 2500.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Bärväskor",
                            Price = 1200.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Tee",
                            Price = 100.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Handskar",
                            Price = 299.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 5,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Paraplyer",
                            Price = 500.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 5,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Handdukar",
                            Price = 200.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 6,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Bollar",
                            Price = 400.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 7,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Puttingmattor",
                            Price = 1000.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 7,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Träningsredskap",
                            Price = 1000.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 8,
                            Description = "",
                            Image = "default.jpg",
                            Name = "GPS-enheter",
                            Price = 2500.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 8,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Avståndsmätare",
                            Price = 1500.00m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 8,
                            Description = "",
                            Image = "default.jpg",
                            Name = "Appar",
                            Price = 1000.00m,
                            Stock = 0
                        });
                });

            modelBuilder.Entity("TucGolfklubb.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TucGolfklubb.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TucGolfklubb.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TucGolfklubb.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TucGolfklubb.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TucGolfklubb.Models.Booking", b =>
                {
                    b.HasOne("TucGolfklubb.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Forum", b =>
                {
                    b.HasOne("TucGolfklubb.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ForumPost", b =>
                {
                    b.HasOne("TucGolfklubb.Models.Forum", "Forum")
                        .WithMany("Posts")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TucGolfklubb.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Forum");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ForumReply", b =>
                {
                    b.HasOne("TucGolfklubb.Models.ForumPost", "ForumPost")
                        .WithMany("Replies")
                        .HasForeignKey("ForumPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TucGolfklubb.Models.ForumReply", "ParentReply")
                        .WithMany("ChildReplies")
                        .HasForeignKey("ParentReplyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TucGolfklubb.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ForumPost");

                    b.Navigation("ParentReply");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TucGolfklubb.Models.OrderItem", b =>
                {
                    b.HasOne("TucGolfklubb.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TucGolfklubb.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TucGolfklubb.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("OrderItems")
                        .HasForeignKey("ShoppingCartId");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Product", b =>
                {
                    b.HasOne("TucGolfklubb.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Review", b =>
                {
                    b.HasOne("TucGolfklubb.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TucGolfklubb.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Forum", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ForumPost", b =>
                {
                    b.Navigation("Replies");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ForumReply", b =>
                {
                    b.Navigation("ChildReplies");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("TucGolfklubb.Models.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("TucGolfklubb.Models.ShoppingCart", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
