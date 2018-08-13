using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelAval
    {
        [Display(Name = "Consumo (1 a 5): ")]
        [Range(1,5)]
        public int Consumo { get; set; }

        [Display(Name = "Espaço (1 a 5*): ")]
        [Range(1, 5)]
        public int Espaco { get; set; }

        [Display(Name = "Avarias (1 a 5*): ")]
        [Range(1, 5)]
        public bool Avarias { get; set; }

        [Display(Name = "Limpeza (1 a 5*): ")]
        [Range(1, 5)]
        public int Limpeza { get; set; }
    }
}