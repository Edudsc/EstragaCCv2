using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("CriteriosCliente")]
    [MetadataType(typeof(ViewModelCritcliente))]
    public partial class Critcliente
    {
        [Key]
        public int CritclienteId { get; set; }

        //[ForeignKey("Particular")]
        //public int ParticularId { get; set; }

        //public virtual Particular Particular { get; set; }

        //[ForeignKey("Servicos")]
        //public int ServicosId { get; set; }

        //public virtual Servicos Servicos { get; set; }

        [Column("Simpatia")]
        public int Simpatia { get; set; }

        [Column("EstadoVeiculo")]
        public int EstadoCarro { get; set; }

        [Column("DataEntrega")]
        public bool DataEntrega { get; set; }

        
    }
}