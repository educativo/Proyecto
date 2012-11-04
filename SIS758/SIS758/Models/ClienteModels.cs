using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace SIS758.Models
{
    public class registrar
    {
        [Required(ErrorMessage = "!")]
       [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre : ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "!")]
        [DataType(DataType.Text)]
       [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Ap. Pat. : ")]
        public string Ap { get; set; }

       [Required(ErrorMessage = "!")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Ap. Mat. : ")]
        public string Am { get; set; }

        [Required(ErrorMessage = "!")]
         [StringLength(100, ErrorMessage = "Minimo 4 caracteres", MinimumLength = 4)]
        [Display(Name = "Doc. de Ident.: ")]
        public string Di { get; set; }

        [Required(ErrorMessage = "!")]
        [Display(Name = "Tipo de Doc: ")]
        public string Td { get; set; }

        [Required(ErrorMessage = "!")]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Pais : ")]
        public string pa { get; set; }

        [Required(ErrorMessage = "!")]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Ciudad : ")]
        public string ciu { get; set; }

        [Required(ErrorMessage = "!")]
        [Display(Name = "Dirección : ")]
        public string dir { get; set; }

        [Display(Name = "Email : ")]
       [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "!")]
        [DataType(DataType.EmailAddress)]
        public string e { get; set; }

        [Display(Name = "Telefono : ")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "!")]
        [DataType(DataType.Text)]
        public  string t { get; set; }


      
        [Required(ErrorMessage = "!")]
        [Display(Name = "fecha")]
        [DataType(DataType.Text)]
        public string fecha { get; set; }

    }
    public class actualizar
    {
        
        [StringLength(100, ErrorMessage = "Minimo 4 caracteres", MinimumLength = 4)]
        [Display(Name = "Buscar: ")]
        public string bu { get; set; }

        [Required(ErrorMessage = "!")]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre : ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "!")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Ap. Pat. : ")]
        public string Ap { get; set; }

        [Required(ErrorMessage = "!")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Ap. Mat. : ")]
        public string Am { get; set; }

        [Required(ErrorMessage = "!")]
        [StringLength(100, ErrorMessage = "Minimo 4 caracteres", MinimumLength = 4)]
        [Display(Name = "Doc. de Ident.: ")]
        public string Di { get; set; }

        [Required(ErrorMessage = "!")]
        [Display(Name = "Tipo de Doc: ")]
        public string Td { get; set; }

        [Required(ErrorMessage = "!")]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Pais : ")]
        public string pa { get; set; }


        [Required(ErrorMessage = "!")]
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "!")]
        [Display(Name = "Ciudad : ")]
        public string ciu { get; set; }

        [Required(ErrorMessage = "!")]
        [Display(Name = "Dirección : ")]
        public string dir { get; set; }

        [Display(Name = "Email : ")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "!")]
        [DataType(DataType.EmailAddress)]
        public string e { get; set; }

        [Display(Name = "Telefono : ")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "!")]
        [DataType(DataType.Text)]
        public string t { get; set; }



        [Required(ErrorMessage = "!")]
        [Display(Name = "fecha")]
        [DataType(DataType.Text)]
        public string fecha { get; set; }

    }

}