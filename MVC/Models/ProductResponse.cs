using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ProductResponse
    {
        [Required(ErrorMessage = "Proszę podać imie i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać adres email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        public string Phone { get; set; }
        public bool? New { get; set; }
    }
}