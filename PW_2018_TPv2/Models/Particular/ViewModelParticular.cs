using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelParticular
    {
        [Required(ErrorMessage = "O nome é campo obrigatório!")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Identificação obrigatório!")]
        [Display(Name = "Identificação(BI): ")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "O BI tem de conter 8 algarismos!")]
        public int Bi { get; set; }

        [Required(ErrorMessage = "O campo Morada obrigatório!")]
        [Display(Name = "Morada: ")]
        public string Morada { get; set; }

        [Display(Name = "Data de Nascimento: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //falta custom validator
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo Carta de Condução é obrigatório")]
        [Display(Name = "Carta de Condução: ")]
        [RegularExpression(@"^[A - Z] -\d{6} \d{1}$",ErrorMessage = "Insira o seu numero da carta de condução no formato Letra(Maiúscula) - (6algarismos)(espaço)1(algarismo)!")]
        public int Cconducao { get; set; }

        [Required]
        [Display(Name = "Email: ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Insira o seu contacto!")]
        [Display(Name = "Contacto: ")]
        [DataType(DataType.PhoneNumber)]
        public int Tel { get; set; }

    }
}