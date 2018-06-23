using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crud_aspnet.Models
{
    public class Clientes
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }

        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public Char Estado { get; set; }
    }
}