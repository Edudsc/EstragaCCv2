using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("ClassificaCliente")]
    [MetadataType(typeof(ViewModelClassifCliente))]
    public partial class ClassifCliente
    {
        [Key]
        public int ClassifClienteId { get; set; }
        
        //[ForeignKey("Particular")]
        //public int ParticularId { get; set; }

        //public virtual Particular Particular{ get; set; }

        [ForeignKey("Critcliente")]
        public int CritclienteId { get; set; }

        public virtual Critcliente Critcliente { get; set; }

        
    }
}