using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{

    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options)
            : base(options)
        { }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Conhecimento> Conhecimentos { get; set; }
    }

    public class Candidato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CandidatoId { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Skype { get; set; }
        public string Telefone { get; set; }
        public string Linkedin { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Portifolio { get; set; }
        public int Disponibilidade { get; set; }
        public int Periodo { get; set; }
        public float Salario { get; set; }
        public string InformacaoBancaria { get; set; }

        public Banco Banco { get; set; }
        public Conhecimento Conhecimento { get; set; }
    }

    public class Banco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BancoId { get; set; }
        public string NomeBanco { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public string Cpf { get; set; }
        public int? TipoConta { get; set; }
        public string NumeroConta { get; set; }
    }

    public class Conhecimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConhecimentoId { get; set; }
        public int Ionic { get; set; }
        public int Android { get; set; }
        public int IOS { get; set; }
        public int? HTML { get; set; }
        public int? CSS { get; set; }
        public int Bootstrap { get; set; }
        public int Jquery { get; set; }
        public int AngularJs { get; set; }
        public int? Java { get; set; }
        public int AspMvc { get; set; }
        public int? C { get; set; }
        public int? Cpp { get; set; }
        public int? Cake { get; set; }
        public int? Django { get; set; }
        public int? Majento { get; set; }
        public int PHP { get; set; }
        public int Wordpress { get; set; }
        public int? Phyton { get; set; }
        public int? Ruby { get; set; }
        public int? MySqlServer { get; set; }
        public int? MySql { get; set; }
        public int? Salesforce { get; set; }
        public int? Photoshop { get; set; }
        public int? Illustrator { get; set; }
        public int? SEO { get; set; }
        public string Others { get; set; }
        public string CrudProjectLink { get; set; }
    }

}
