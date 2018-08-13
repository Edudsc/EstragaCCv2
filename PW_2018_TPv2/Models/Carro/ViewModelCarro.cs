using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelCarro
    {
        [Required(ErrorMessage = "O campo Ficha de avaliação é obrigatório!")]
        [Display(Name = "Ficha de avaliação do Carro: ")]
        public int AvalcarroId { get; set; }

        [Required(ErrorMessage = "O campo Condições de aluguer é obrigatório!")]
        [Display(Name = "Condições de aluguer: ")]
        public int CondAlugarId { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório!")]
        [Display(Name = "Nome: ")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O campo Marca é obrigatório!")]
        [Display(Name = "Marca: ")]
        public string Marca { get; set; }

        //
        [Required(ErrorMessage = "O campo Matricula obedece a norma ##-AA-## e é obrigatório!")]
        [Display(Name = "Matricula: ")]
        [RegularExpression(@"^\d{2}-([A-Z][A-Z])-\d{2}$", ErrorMessage = "Matricula inválida!")]
        public string Matricula { get; set; }

        //dropdownlist
        [Required(ErrorMessage = "O campo Combustivél é obrigatório!")]
        [Display(Name = "Combustivél: ")]
        public Combustivel Gas { get; set; }

        [Required(ErrorMessage = "O campo Ano é obrigatório!")]
        [Display(Name = "Ano: ")]
        //inserir custom validator para verificar se o ano não é superior ao ano currente
        public int Ano { get; set; }

        [Required(ErrorMessage = "O campo Preço/dia é obrigatório!")]
        [Display(Name = "Preço/dia: ")]
        public int Preçod { get; set; }

        [Required(ErrorMessage = "O campo Preço/Mês é obrigatório!")]
        [Display(Name = "Preço/Mês: ")]
        public int Preçom { get; set; }

    }
}