using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCandy
{
    public class Dulce
    {
        public int Id { get; set; }

        public enum Color
        {
            red,
            blue,
            yellow,
            orange,
            green,
        };

        public Color color { get; set; }

        public string Imagen { get; set; }
    }
}