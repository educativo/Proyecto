using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace SIS758.Models
{
    public class ingresar
    {
       //[HttpPost]
        [Required(ErrorMessage="Ingrese datos porfavor")]
        [StringLength(100, ErrorMessage = "Minimo 4 caracteres", MinimumLength = 4)]
        [Display(Name = "usu")]
        [DataType(DataType.Text)]
        public string usua { get; set; }


        [Required(ErrorMessage = "Ingrese datos por favor")]
        [Display(Name = "pa")]
        [DataType(DataType.Password)]
        public string pas { get; set; }

    }
    public class aux
    {
        public string id { get; set; }
        public string nom { get; set; }
        
    }
}