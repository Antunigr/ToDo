﻿// <auto-generated />
using System;
using Crud.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crud.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230411102003_NewTarefas")]
    partial class NewTarefas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Crud.Api.Models.Tarefas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tarefa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TarefasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TarefasId");

                    b.ToTable("TaksRegister");
                });

            modelBuilder.Entity("Crud.Api.Models.Tarefas", b =>
                {
                    b.HasOne("Crud.Api.Models.Tarefas", null)
                        .WithMany("ListMasterTarefas")
                        .HasForeignKey("TarefasId");
                });

            modelBuilder.Entity("Crud.Api.Models.Tarefas", b =>
                {
                    b.Navigation("ListMasterTarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
