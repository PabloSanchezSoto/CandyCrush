using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCandy
{
    public class Partida
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public int puntos { get; set; }
        public int totalMovimientos { get; set; }
        public List<Dulce> dulces { get; set; }
    }
}