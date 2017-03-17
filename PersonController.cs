using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apies.Models;
using System.Text;
namespace apies.Controllers
{
    public class PersonController : ApiController
    {

        [HttpGet]
        [Route("api/person/{cantidad}")]
        public List<Persona> GetPersona(int cantidad)
        {
            System.Web.HttpContext.Current.Response.Headers.Add("X-Total", "100");
             List<Persona> lista = new  List<Persona>();

             if (cantidad==1)
             {
                 lista.Add(new Persona { Id = 1, Name = "pepe" });
             }
             if (cantidad==2)
             {
                 lista.Add(new Persona { Id = 1, Name = "chcoc" } );
                 lista.Add(new Persona { Id = 2, Name = "pupo" });
             }
             return lista;
        }

        [HttpGet]
        [Route("api/person/pumba/{pagina:int}/{itemsPorPagina:int}/{nombre}/{zona=ninguna}")]
        public string GetData(int pagina,int itemsPorPagina,string nombre,string zona )
        {

            System.Web.HttpContext.Current.Response.Headers.Add("X-Total", "100");
            string result = "";
            if (!zona.Equals("ninguna"))
            {
                 result+=zona;
            }
            return result+=nombre;

        }
    }
}
