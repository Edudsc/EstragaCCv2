using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelZonas
    {
        [Required(ErrorMessage = "O campo Zona é obrigatório!")]
        [Display(Name = "Zona de Aluguer: ")]
        public string NomeZona { get; set; }
    }
}