// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceFlight.Data;

namespace SpaceFlight.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220212023901_AddSecMigration")]
    partial class AddSecMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("SpaceFlight.Models.ArticlesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Featured")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("NewsSite")
                        .HasColumnType("longtext");

                    b.Property<string>("PublishedAt")
                        .HasColumnType("longtext");

                    b.Property<string>("Summary")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("SpaceFlight.Models.EventsModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(95)");

                    b.Property<int?>("ArticlesModelId")
                        .HasColumnType("int");

                    b.Property<string>("Provider")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArticlesModelId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SpaceFlight.Models.LaunchesModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(95)");

                    b.Property<int?>("ArticlesModelId")
                        .HasColumnType("int");

                    b.Property<string>("Provider")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArticlesModelId");

                    b.ToTable("Launches");
                });

            modelBuilder.Entity("SpaceFlight.Models.EventsModel", b =>
                {
                    b.HasOne("SpaceFlight.Models.ArticlesModel", null)
                        .WithMany("Events")
                        .HasForeignKey("ArticlesModelId");
                });

            modelBuilder.Entity("SpaceFlight.Models.LaunchesModel", b =>
                {
                    b.HasOne("SpaceFlight.Models.ArticlesModel", null)
                        .WithMany("Launches")
                        .HasForeignKey("ArticlesModelId");
                });

            modelBuilder.Entity("SpaceFlight.Models.ArticlesModel", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Launches");
                });
#pragma warning restore 612, 618
        }
    }
}
