using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EniWine.Investigacao.Library.Models
{
    [Table("Arma")]
    public class Arma
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "'Nome' não pode ser maior do que 100 caracteres")]
        public string Nome { get; set; }
    }
}