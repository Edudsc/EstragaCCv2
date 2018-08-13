using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("AvaliaCarro")]
    [MetadataType(typeof(ViewModelAval))]
    public partial class Avalcarro
    {
        [Key]
        [Column("Id")]
        public int AvalcarroId { get; set; }

        //Foreign Key do Carro
        //[ForeignKey("Carro")]
        //public int CarroId { get; set; }

        //public virtual Carro Carro { get; set; }
        
        //[ForeignKey("Servicos")]
        //public int ServicosId { get; set; }

        //public virtual Servicos Servicos { get; set; }

        [Column("Consumo")]
        public int Consumo { get; set; }

        [Column("Espaco")]
        public int Espaco { get; set; }

        [Column("Avarias")]
        public bool Avarias { get; set; }

        [Column("Limpeza")]
        public int Limpeza { get; set; }

    }
}