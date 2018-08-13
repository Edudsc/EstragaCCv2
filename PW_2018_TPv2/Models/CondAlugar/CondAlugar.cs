using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("CondicoesdeAluguer")]
    [MetadataType(typeof(ViewModelCondAlugar))]
    public partial class CondAlugar
    {
        [Key]
        public int CondAlugaId { get; set; }

        //[ForeignKey("Carro")]
        //public int CarroId { get; set; }

        //public virtual Carro Carro{ get; set; }
        //FK da zona
        [ForeignKey("Zonas")]
        public int ZonaId { get; set; }

        public virtual Zonas Zonas { get; set; }

        [Column("DataInicial")]
        public DateTime DataInit { get; set; }

        [Column("DataFinal")]
        public DateTime DataFim { get; set; }

        [Column("Seguro")]
        public string Seguro { get; set; }


        [Column("PrePagamento")]
        public bool Pagaradiantado { get; set; }


        [Column("IdadeMinima")]
        public int Idade { get; set; }


        [Column("TempodeCarta (Meses)")]
        public int Tempocarta { get; set; }


        [Column("ClassificacaoMinimaRequerida")]
        public int CassificacaoMinCli { get; set; }
      
    }
}