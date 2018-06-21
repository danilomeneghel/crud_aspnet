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
        public String Nome { get; set; }
        public String Email { get; set; }
        public int Telefone { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public Char Estado { get; set; }
    }
}