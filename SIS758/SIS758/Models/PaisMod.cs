using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace SIS758.Models
{
    public class Registrarpa
    {
        [Required(ErrorMessage = "Debe registrar el nombre")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "Solo letras")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe registrar el nombre")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "solo letras")]
        [Display(Name = "Sitema monetario")]
        public string SisMone { get; set; }

        [Required(ErrorMessage = "Debe ingresar")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "Solo letras")]
        [Display(Name = "Moneda")]
        public string Mon { get; set; }

        [Required(ErrorMessage = "Debe registrar")]
        [DataType(DataType.Text)]
        [RegularExpression("^[0-9]")]
        [Display(Name = "Tipo Cambio")]
        public string Tipocam { get; set; }

    }
}