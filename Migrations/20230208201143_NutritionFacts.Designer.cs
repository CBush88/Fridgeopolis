﻿// <auto-generated />
using System;
using Renipe.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Renipe.Migrations
{
    [DbContext(typeof(RenipeDBContext))]
    [Migration("20230208201143_NutritionFacts")]
    partial class NutritionFacts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Renipe.Models.Datum", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("RecipeDataID")
                        .HasColumnType("int");

                    b.Property<string>("step")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("RecipeDataID");

                    b.ToTable("Datum");
                });

            modelBuilder.Entity("Renipe.Models.NutritionFacts", b =>
                {
                    b.Property<int>("NutritionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("nutrition_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NutritionId"));

                    b.Property<int>("CaloriesPerServing")
                        .HasColumnType("int")
                        .HasColumnName("calories");

                    b.Property<int>("CarbohydratesPerServing")
                        .HasColumnType("int")
                        .HasColumnName("carbohydrates");

                    b.Property<int>("FatPerServing")
                        .HasColumnType("int")
                        .HasColumnName("fat");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("food_name");

                    b.Property<int>("PhosphorusPerServing")
                        .HasColumnType("int")
                        .HasColumnName("phosphorus");

                    b.Property<int>("PotassiumPerServing")
                        .HasColumnType("int")
                        .HasColumnName("potassium");

                    b.Property<int>("ProteinPerServing")
                        .HasColumnType("int")
                        .HasColumnName("protein");

                    b.Property<double>("Servings")
                        .HasColumnType("float")
                        .HasColumnName("servings");

                    b.Property<int>("SodiumPerServing")
                        .HasColumnType("int")
                        .HasColumnName("sodium");

                    b.HasKey("NutritionId");

                    b.ToTable("NutritionData");
                });

            modelBuilder.Entity("Renipe.Models.PropertyModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("SourceUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PropertyRecipe");
                });

            modelBuilder.Entity("Renipe.Models.RecipeData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadyInMinutes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RecipeData");
                });

            modelBuilder.Entity("Renipe.Models.Datum", b =>
                {
                    b.HasOne("Renipe.Models.RecipeData", null)
                        .WithMany("Steps")
                        .HasForeignKey("RecipeDataID");
                });

            modelBuilder.Entity("Renipe.Models.RecipeData", b =>
                {
                    b.Navigation("Steps");
                });
#pragma warning restore 612, 618
        }
    }
}
