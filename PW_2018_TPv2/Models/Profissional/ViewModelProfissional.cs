using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PW_2018_TPv2.Models
{
    public class ViewModelProfissional
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Denominação Social é obrigatório")]
        [Display(Name = "Denominação Social: ")]
        public string Social { get; set; }

        [Required(ErrorMessage = "O campo Morada é obrigatório")]
        [Display(Name = "Morada: ")]
        public string Morada { get; set; }

        [Required(ErrorMessage = "O campo Zonas é obrigatório")]
        [Display(Name = "Adicione Zonas onde o carro pode circular: ")]
        public IList<Zonas> Zonases { get; set; }

        [Required(ErrorMessage = "O campo Data de fundação ou registo é obrigatório")]
        [Display(Name = "Data de Registo/Fundação: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //custom validator em falta
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "Email: ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Contacto: ")]
        [DataType(DataType.PhoneNumber)]
        public int Tel { get; set; }
    }
}