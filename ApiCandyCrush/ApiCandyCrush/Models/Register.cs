using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCandyCrush.Models
{
    public class Register
    {
        [Key]
        public int id { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
    }
}