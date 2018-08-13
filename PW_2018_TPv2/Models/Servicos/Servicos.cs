using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("Servicos")]
    [MetadataType(typeof(ViewModelServico))]
    public partial class Servicos
    {
        [Key]
        public int ServicosId { get; set; }

        [ForeignKey("Carro")]
        public int CarroId { get; set; }

        public virtual Carro Carro { get; set; }

        public IList<Particular> Particulars { get; set; }

        //pode ser nullable quando é entre dois Particulares
        [ForeignKey("Profissional")]
        public int? ProfissionalId { get; set; }

        public virtual Profissional Profissional { get; set; }

        [Column("DataInicial")]
        public DateTime DataInit { get; set; }

        [Column("DataFinal")]
        public DateTime DataFim { get; set; }

    }
}