using ApiCandyCrush.Entitys;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;
using static ApiCandyCrush.Entitys.Dulce;
using ApiCandyCrush.Models;

namespace ApiCandyCrush.Controllers
{
    public class PartidaController : ApiController
    {
        static Partida oPartida;
        static List<Dulce> listElementos;
 
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // POST api/Partida
        public async Task<IHttpActionResult> PostPartida([FromBody] ApplicationUser user )
        {
            Array values = Enum.GetValues(typeof(Color));
            Random random = new Random();
            var randomColor = Color.green;
            
            listElementos = new List<Dulce>();

            for (int i = 0; i < 81; i++)
            {
                              randomColor = (Color)values.GetValue(random.Next(values.Length));
                listElementos.Add(new Dulce { id = i, color = randomColor });
            }

            oPartida = new Partida();
            oPartida.id = 1;
            oPartida.dulces = listElementos;
            return Json(oPartida);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // Put api/Partida
        public async Task<IHttpActionResult> PutPartida(int id,
            [FromBody] Movimiento usuarioMovimientos)
        {
            //Logica de negocios

            var move = listElementos.First(x => x.id == usuarioMovimientos.movimiento1);
            listElementos.Remove(move);
            move.id = usuarioMovimientos.movimiento2;

            var move2 = listElementos.First(x => x.id == usuarioMovimientos.movimiento2);
            listElementos.Remove(move2);
            move2.id = usuarioMovimientos.movimiento1;

            listElementos.Add(move);
            listElementos.Add(move2);

            oPartida.dulces = listElementos.OrderBy(x => x.id).ToList();
            return Json(oPartida);
        }

    }
}
