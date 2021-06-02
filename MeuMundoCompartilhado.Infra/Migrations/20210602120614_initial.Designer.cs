﻿// <auto-generated />
using System;
using MeuMundoCompartilhado.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeuMundoCompartilhado.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210602120614_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeuMundoCompartilhado.Domain.Entities.Compromisso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PessoaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Compromissos");
                });

            modelBuilder.Entity("MeuMundoCompartilhado.Domain.Entities.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataAniversario")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("MeuMundoCompartilhado.Domain.Entities.Compromisso", b =>
                {
                    b.HasOne("MeuMundoCompartilhado.Domain.Entities.Pessoa", null)
                        .WithMany("Compromissos")
                        .HasForeignKey("PessoaId");

                    b.OwnsOne("MeuMundoCompartilhado.Domain.ValueObjects.StatusCompromisso", "Status", b1 =>
                        {
                            b1.Property<Guid>("CompromissoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Descricao")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("StatusDescricao");

                            b1.Property<int>("Situacao")
                                .HasColumnType("int")
                                .HasColumnName("StatusSituacao");

                            b1.HasKey("CompromissoId");

                            b1.ToTable("Compromissos");

                            b1.WithOwner()
                                .HasForeignKey("CompromissoId");
                        });

                    b.Navigation("Status");
                });

            modelBuilder.Entity("MeuMundoCompartilhado.Domain.Entities.Pessoa", b =>
                {
                    b.OwnsOne("MeuMundoCompartilhado.Domain.ValueObjects.Parentesco", "Parentesco", b1 =>
                        {
                            b1.Property<Guid>("PessoaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Descricao")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("ParentescoDescricao");

                            b1.Property<int>("Tipo")
                                .HasColumnType("int")
                                .HasColumnName("ParentescoTipo");

                            b1.HasKey("PessoaId");

                            b1.ToTable("Pessoas");

                            b1.WithOwner()
                                .HasForeignKey("PessoaId");
                        });

                    b.Navigation("Parentesco");
                });

            modelBuilder.Entity("MeuMundoCompartilhado.Domain.Entities.Pessoa", b =>
                {
                    b.Navigation("Compromissos");
                });
#pragma warning restore 612, 618
        }
    }
}
