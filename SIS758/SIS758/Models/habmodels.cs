using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization;
using System.Web.Security;
using System.Web.Mvc;


namespace SIS758.Models
{
    public class registrarhab
    {
        [Required(ErrorMessage="!")]
        [DataType(DataType.Text)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "!")]
        public string Nro{get;set;}

        
        [Required(ErrorMessage="!")]
        [DataType(DataType.Text)]
        [Display(Name = "Tipo. : ")]
        public string Tipo { get; set; }

        [Required(ErrorMessage="!")]
        [DataType(DataType.Text)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "!")]
        [Display(Name = "Precio. : ")]
        public string Pres { get; set; }

        [Required(ErrorMessage="!")]
        [Display(Name = "Estado : ")]
        public string Est { get; set; }
    

        [Required(ErrorMessage="!")]
        [DataType(DataType.Text)]
        [Display(Name = "Descripcion: ")]
        public string Des { get; set; }

        

    }
    public class Acthab

    {
       
        [Display(Name = "Buscar: ")]
        public string bu { get; set; }

        [Required(ErrorMessage = "Debe regitrar Nro.")]
        [DataType(DataType.Text)]
        [Display(Name = "Numero:")]
        public string Nro { get; set; }

        [Required(ErrorMessage = "!")]
        [Display(Name = "Tipo. :")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "!")]
        [DataType(DataType.Text)]
        [Display(Name = "Precio. :")]
        public string Pres { get; set; }

        [Required(ErrorMessage = "!")]
        [Display(Name = "Estado :")]
        public string Est { get; set; }
        

        [Required(ErrorMessage = "!")]
        [DataType(DataType.Text)]
        [Display(Name = "Descripcion:")]
        public string Des { get; set; }
    }
    public class modelha
    {
        public string maiz { get; set; }
    }
}
