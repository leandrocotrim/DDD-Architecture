using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Events
{
    public abstract class DomainEvent<T>
    {
        private readonly T _source;
        protected DomainEvent(T source) { _source = source; }
        public T Source { get { return _source; } }
    }
}