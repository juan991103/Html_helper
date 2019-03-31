using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace html_helper.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Apellido { get; set; }
        [Range(15, 120, ErrorMessage = "Se permite mayores de 15 años")]
        public int Edad { get; set; }
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage = "Introduce un correo valido")]
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Hobbys { get; set; }
    }
}