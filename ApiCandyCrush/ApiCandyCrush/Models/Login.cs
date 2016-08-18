using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCandyCrush.Models
{
    public class Login
    {
        [Key]
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
    }
}