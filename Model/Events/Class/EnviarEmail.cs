using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Events
{
    public class EnviarEmail
    {
        public string Email { get; private set; }
        public EnviarEmail(string email) { Email = email; }
    }
}
