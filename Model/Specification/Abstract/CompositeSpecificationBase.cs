using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model.Specification
{
    public abstract class CompositeSpecificationBase<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _leftExpr;
        private readonly ISpecification<T> _rightExpr;

        protected CompositeSpecificationBase(ISpecification<T> left, ISpecification<T> right)
        {
            _leftExpr = left;
            _rightExpr = right;
        }

        public ISpecification<T> Left { get { return _leftExpr; } }
        public ISpecification<T> Right { get { return _rightExpr; } }

        public abstract bool IsSatisfiedBy(T obj);
    }
}
