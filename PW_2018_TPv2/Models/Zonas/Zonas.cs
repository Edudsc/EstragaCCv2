using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using PW_2018_TPv2.Models;

namespace PW_2018_TPv2.Models
{
    [Table("Zonas")]
    [MetadataType(typeof(ViewModelZonas))]
    public partial class Zonas
    {
        [Key]
        public int ZonasId { get; set; }

        [Column("ZonadeAluger")]
        public string NomeZona { get; set; }
        
    }
}