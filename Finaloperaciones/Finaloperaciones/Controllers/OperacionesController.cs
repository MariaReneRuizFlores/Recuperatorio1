using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finaloperaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        [HttpGet]
        public string texto(int n)
        {
            string respuesta = "";
            if (n > 0)
            {
                respuesta = "Usted ingresó el número " + n;
            }
            if (n < 0)
            {
                respuesta = "ERROR";
            }
            if (n == 0)
            {
                respuesta = "Realizado por María René Ruiz Flores";
            }
            return respuesta;
        }
    }
}
