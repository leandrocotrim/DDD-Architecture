using RepositoryEF.Repositories.Consultorio.Agenda;
using Service.Consultorio.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Consultorio.Agenda
{
    public class SrvAgenda : ISrvAgenda
    {
        private IRepAgenda _repAgenda;
        public SrvAgenda(IRepAgenda repAgenda)
        {
            _repAgenda = repAgenda;
        }

        public string ObeterString()
        {
            return _repAgenda.ObeterString();
        }
    }
}
