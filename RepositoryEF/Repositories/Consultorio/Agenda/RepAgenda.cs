using RepositoryEF.Repositories.Consultorio.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Repositories.Consultorio.Agenda
{
    public partial class RepAgenda : IRepAgenda, IDisposable
    {
        public string ObeterString()
        {
            return "string do repository EF....";
        }

        public void Dispose() { }
    }
}