﻿// <auto-generated />
using CrudAluno.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudAluno.Migrations
{
    [DbContext(typeof(AlunoContext))]
    partial class AlunoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CrudAluno.Model.Aluno", b =>
                {
                    b.Property<int>("RA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("RA");

                    b.ToTable("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}