using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;


namespace PW_2018_TPv2.Models
{
    public enum Combustivel
    {
        Gasolina,
        Gasóleo,
        Gas,
        Eletrico
    }
    [Table("Carros")]
    [MetadataType(typeof(ViewModelCarro))]
    public partial class Carro
    {
        [Key]
        public int CarroId { get; set; }

        [ForeignKey("Avalcarro")]
        public int AvalcarroId { get; set; }

        public virtual Avalcarro Avalcarro { get; set; }

        [ForeignKey("CondAlugar")]
        public int CondAlugarId { get; set; }

        public virtual CondAlugar CondAlugar { get; set; }

        [Column("Modelo")]
        public string Modelo { get; set; }

        [Column("Marca")]
        public string Marca { get; set; }

        //restriçoes
        [Column("Matricula")]
        public string Matricula { get; set; }

        //dropdownlist
        [Column("Combustivél")]
        public Combustivel Gas{ get; set; }

        [Column("Ano")]
        public int Ano { get; set; }

        [Column("Preço/Dia")]
        public int Preçod { get; set; }

        [Column("Preço/Mes")]
        public int Preçom { get; set; }

        
        public IList<Servicos> Servicoses { get; set; }
      
    }
}