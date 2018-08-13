using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("CriteriosFornecedor")]
    [MetadataType(typeof(ViewModelCritFonecedor))]
    public partial class CritFornecedor
    {
        [Key]
        public int CritFornecedorId { get; set; }
        
        //[ForeignKey("Particular")]
        //public int? ParticularId { get; set; }

        //public virtual Particular Particular { get; set; }

        //[ForeignKey("Profissional")]
        //public int? ProfissionalId { get; set; }

        //public virtual Profissional Profissional { get; set; }

        //[ForeignKey("Servicos")]
        //public int ServicosId { get; set; }

        //public virtual Servicos Servicos { get; set; }

        [Column("Simpatia")]
        public int Simpatia { get; set; }

        [Column("Estado do Veículo")]
        public int EstadoCarro { get; set; }

        [Column("Data de Entrega")]
        public bool DataEntrega { get; set; }

        [Column("Responsividade")]
        public int RapidezRsp { get; set; }


    }
}