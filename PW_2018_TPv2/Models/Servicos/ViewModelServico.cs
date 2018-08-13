using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelServico
    {
        [Required(ErrorMessage = "O campo ID do Carro obrigatório!")]
        [Display(Name = "Introduza o ID do carro a alugar: ")]
        public int CarroId { get; set; }

        //pode ser nullable quando é entre dois Particulares
        
        [Display(Name = "Selecione o ID do Profissional ou Prticular a que vai alugar: ")]
        public int? ProfissionalId { get; set; }

        [Required(ErrorMessage = "O campo Data de Recolha é obrigatório")]
        [Display(Name = "Data de Recolha: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInit { get; set; }

        [Required(ErrorMessage = "O campo Data de Entrega é obrigatório")]
        [Display(Name = "Data de Entrega: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFim { get; set; }

    }
}