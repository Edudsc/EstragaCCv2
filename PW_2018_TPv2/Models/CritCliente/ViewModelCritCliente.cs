using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelCritcliente
    {
        [Required(ErrorMessage = "Introduza o Id do cliente que pretende avaliar")]
        [Display(Name = "ID do cliente: ")]
        public int CritclienteId { get; set; }

        [Required(ErrorMessage = "O campo Simpatia é de preenchimento obrigatório")]
        [Display(Name = "Simpatia: (1 a 5)")]
        [Range(1,5)]
        public int Simpatia { get; set; }

        [Required(ErrorMessage = "O campo Estado do veículo é de preenchimento obrigatório")]
        [Display(Name = "Estado do Veículo (1 a 5): ")]
        [Range(1,5)]
        public int EstadoCarro { get; set; }

        [Required(ErrorMessage = "O campo Cumpriu a data de entrega? é de preenchimento obrigatório")]
        [Display(Name = "Cumpriu a data de entrega?")]
        public bool DataEntrega { get; set; }
    }
}