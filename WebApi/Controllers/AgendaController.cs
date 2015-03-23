using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class AgendaController : ApiController
    {
        private Service.ISrvAgenda _srvAgenda;
        public AgendaController(Service.ISrvAgenda srvAgenda)
        {
            _srvAgenda = srvAgenda;
        }

        [HttpGet]
        public string Teste()
        {
            return "funcionou";
        }
    }
}
