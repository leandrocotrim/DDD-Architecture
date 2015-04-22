using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model.Specification
{
    public class NegatedSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _inner;
        
        public NegatedSpecification(ISpecification<T> inner)
        {
            _inner = inner;
        }

        public ISpecification<T> Inner
        {
            get { return _inner; }
        }

        public bool IsSatisfiedBy(T obj)
        {
            return !_inner.IsSatisfiedBy(obj);
        }
    }
}
