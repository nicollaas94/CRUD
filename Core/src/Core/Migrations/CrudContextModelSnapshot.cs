using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Core.Model;

namespace Core.Migrations
{
    [DbContext(typeof(CrudContext))]
    partial class CrudContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Model.Banco", b =>
                {
                    b.Property<int>("BancoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agencia");

                    b.Property<string>("Cpf");

                    b.Property<string>("NomeBanco");

                    b.Property<string>("NumeroConta");

                    b.Property<int?>("TipoConta");

                    b.Property<string>("Titular");

                    b.HasKey("BancoId");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("Core.Model.Candidato", b =>
                {
                    b.Property<int>("CandidatoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BancoId");

                    b.Property<string>("Cidade");

                    b.Property<int?>("ConhecimentoId");

                    b.Property<int>("Disponibilidade");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<string>("InformacaoBancaria");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Nome");

                    b.Property<int>("Periodo");

                    b.Property<string>("Portifolio");

                    b.Property<float>("Salario");

                    b.Property<string>("Skype");

                    b.Property<string>("Telefone");

                    b.HasKey("CandidatoId");

                    b.HasIndex("BancoId");

                    b.HasIndex("ConhecimentoId");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("Core.Model.Conhecimento", b =>
                {
                    b.Property<int>("ConhecimentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Android");

                    b.Property<int>("AngularJs");

                    b.Property<int>("AspMvc");

                    b.Property<int>("Bootstrap");

                    b.Property<int?>("C");

                    b.Property<int?>("CSS");

                    b.Property<int?>("Cake");

                    b.Property<int?>("Cpp");

                    b.Property<string>("CrudProjectLink");

                    b.Property<int?>("Django");

                    b.Property<int?>("HTML");

                    b.Property<int>("IOS");

                    b.Property<int?>("Illustrator");

                    b.Property<int>("Ionic");

                    b.Property<int?>("Java");

                    b.Property<int>("Jquery");

                    b.Property<int?>("Majento");

                    b.Property<int?>("MySql");

                    b.Property<int?>("MySqlServer");

                    b.Property<string>("Others");

                    b.Property<int>("PHP");

                    b.Property<int?>("Photoshop");

                    b.Property<int?>("Phyton");

                    b.Property<int?>("Ruby");

                    b.Property<int?>("SEO");

                    b.Property<int?>("Salesforce");

                    b.Property<int>("Wordpress");

                    b.HasKey("ConhecimentoId");

                    b.ToTable("Conhecimentos");
                });

            modelBuilder.Entity("Core.Model.Candidato", b =>
                {
                    b.HasOne("Core.Model.Banco", "Banco")
                        .WithMany()
                        .HasForeignKey("BancoId");

                    b.HasOne("Core.Model.Conhecimento", "Conhecimento")
                        .WithMany()
                        .HasForeignKey("ConhecimentoId");
                });
        }
    }
}
