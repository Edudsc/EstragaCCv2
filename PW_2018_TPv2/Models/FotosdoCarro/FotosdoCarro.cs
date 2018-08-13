using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("Fotos")]
    [MetadataType(typeof(ViewModelFotos))]
    public partial class FotosdoCarro
    {
        [Key]
        public int FotosdoCarroId { get; set; }

        //[ForeignKey("Carro")]
        //public int CarroId { get; set; }
        
        //public virtual Carro Carro { get; set; }


    }
}