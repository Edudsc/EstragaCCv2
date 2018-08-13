using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("Profissionais")]
    [MetadataType(typeof(ViewModelProfissional))]
    public partial class Profissional
    {
        [Key]
        public int ProfissionalId { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("DenominacaoSocial")]
        public string Social { get; set; }

        [Column("Morada")]
        public string Morada { get; set; }

        [Column("Distrito")]
        public IList<Zonas> Zonases { get; set; }

        [Column("DatadeFundacao")]
        public DateTime DataNascimento { get; set; }
        
        [Column("Email")]
        public string Email { get; set; }

        
        [Column("Telefone")]
        public int Tel { get; set; }

        //tem avaliação como fornecedor
        public IList<ClassifFornecedor> Classificaforn { get; set; }

        //tem um ou mais carros para alugar
        public IList<Carro> Carros { get; set; }

        //presta serviços
        public IList<Servicos> Servicoses { get; set; }

        //Lista de mensagens?
        public IList<Mensagem> Mensagens { get; set; }

    }
}