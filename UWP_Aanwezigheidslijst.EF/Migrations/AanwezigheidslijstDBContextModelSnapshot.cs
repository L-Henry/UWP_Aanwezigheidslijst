﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UWP_Aanwezigheidslijst.EF;

namespace UWP_Aanwezigheidslijst.EF.Migrations
{
    [DbContext(typeof(AanwezigheidslijstDBContext))]
    partial class AanwezigheidslijstDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("UWP_Aanwezigheidslijst.EF.Model.Docent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bedrijf");

                    b.Property<string>("Naam");

                    b.HasKey("Id");

                    b.ToTable("Docenten");
                });
#pragma warning restore 612, 618
        }
    }
}