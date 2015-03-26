using Service.Consultorio.Agenda;
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
        private ISrvAgenda _srvAgenda;
        public AgendaController(ISrvAgenda srvAgenda)
        {
            _srvAgenda = srvAgenda;
        }

        [HttpGet]
        public string Teste()
        {
            return _srvAgenda.ObeterString();
        }
    }
}
