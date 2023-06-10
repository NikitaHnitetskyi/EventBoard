﻿// <auto-generated />
using EventBoardDataAccess.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventBoardDataAccess.Migrations
{
    [DbContext(typeof(RoleContext))]
    partial class RoleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.EventMember", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id", "EventId", "UserId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("EventMembers");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.EventOrganizer", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("EventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("EventOrganizers");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.EventSponsor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("SponsorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("EventSponsors");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.EventMember", b =>
                {
                    b.HasOne("EventBoardDataAccess.DataBase.Models.Event", "Event")
                        .WithMany("EventMembers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventBoardDataAccess.DataBase.Models.User", "User")
                        .WithMany("EventMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.EventOrganizer", b =>
                {
                    b.HasOne("EventBoardDataAccess.DataBase.Models.Event", "Event")
                        .WithMany("EventOrganizers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventBoardDataAccess.DataBase.Models.User", "User")
                        .WithMany("EventOrganizers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.EventSponsor", b =>
                {
                    b.HasOne("EventBoardDataAccess.DataBase.Models.Event", "Event")
                        .WithMany("EventSponsors")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.User", b =>
                {
                    b.HasOne("EventBoardDataAccess.DataBase.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.Event", b =>
                {
                    b.Navigation("EventMembers");

                    b.Navigation("EventOrganizers");

                    b.Navigation("EventSponsors");
                });

            modelBuilder.Entity("EventBoardDataAccess.DataBase.Models.User", b =>
                {
                    b.Navigation("EventMembers");

                    b.Navigation("EventOrganizers");
                });
#pragma warning restore 612, 618
        }
    }
}