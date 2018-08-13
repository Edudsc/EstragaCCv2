using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelCondAlugar
    {
        [Required(ErrorMessage = "Introduza o Id da zona onde pretende que o carro seja recolhido")]
        [Display(Name = "Zona: ")]
        public int ZonaId { get; set; }

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


        [Required(ErrorMessage = "Introduza o Nome da Seguradora")]
        [Display(Name = "Seguradora: ")]
        public string Seguro { get; set; }


        [Required(ErrorMessage = "Escolha se pretende pré-pagamento do serviço")]
        [Display(Name = "Pré-pagamento: ")]
        public bool Pagaradiantado { get; set; }


        [Required(ErrorMessage = "Introduza a idade minima de quem pretende que alugue o carro")]
        [Display(Name = "Idade minima do cliente: ")]
        public int Idade { get; set; }


        [Required(ErrorMessage = "Introduza o Tempo minimo de carta de quem pretende que alugue o carro")]
        [Display(Name = "Tempo de carta requerido: ")]
        public int Tempocarta { get; set; }


        [Required(ErrorMessage = "Introduza a classificação minima de que pretende que alugue o carro")]
        [Display(Name = "Classificação minima do cliente: ")]
        public int CassificacaoMinCli { get; set; }
    }
}