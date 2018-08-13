using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("ClassificaFornecedor")]
    [MetadataType(typeof(ViewModelClassifFornecedor))]
    public partial class ClassifFornecedor
    {
        [Key]
        public int ClassificaFornecedorId { get; set; }

        //[ForeignKey("Particular")]
        //public int? ParticularId { get; set; }

        //public virtual Particular Particular { get; set; }

        //[ForeignKey("Profissional")]
        //public int? ProfissionalId { get; set; }

        //public virtual Profissional Profissional { get; set; }

        [ForeignKey("CritFornecedor")]
        public int CritFornecedorId { get; set; }

        public virtual CritFornecedor CritFornecedor { get; set; }

    }
}