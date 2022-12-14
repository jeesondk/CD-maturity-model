// <auto-generated />
using System;
using CDMM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CDMM.Migrations
{
    [DbContext(typeof(SurveyContext))]
    partial class SurveyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("CDMM.Entities.DataPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("app")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("axis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("DataPoint", (string)null);
                });

            modelBuilder.Entity("CDMM.Entities.Respondent", b =>
                {
                    b.Property<int>("RespondentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("TEXT");

                    b.HasKey("RespondentId");

                    b.ToTable("Respondent", (string)null);
                });

            modelBuilder.Entity("CDMM.Entities.SurveyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Survey", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
