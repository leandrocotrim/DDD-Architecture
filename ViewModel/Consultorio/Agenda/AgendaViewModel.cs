using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AgendaViewModel : BaseViewModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }

        public Guid MedicoId { get; set; }
        public string MedicoNome { get; set; } 
    }
}
