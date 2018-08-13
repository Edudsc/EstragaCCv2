using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

using System.Data.Entity;


namespace PW_2018_TPv2.Models
{
    public class DbInfo : DbContext
    {
        public DbInfo() : base("name=DefaultConnection")
        {

        }
        public DbSet<Avalcarro> Avalcarros { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<ClassifCliente> ClassifClientes { get; set; }
        public DbSet<ClassifFornecedor> ClassifFornecedors { get; set; }
        public DbSet<CondAlugar> CondAlugars { get; set; }
        public DbSet<Critcliente> Critclientes { get; set; }
        public DbSet<CritFornecedor> CritFornecedors { get; set; }
        public DbSet<FotosdoCarro> FotosdoCarros { get; set; }
        public DbSet<Mensagem> Mensagems { get; set; }
        public DbSet<Particular> Particulares { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Servicos> Servicoses { get; set; }
    }
}