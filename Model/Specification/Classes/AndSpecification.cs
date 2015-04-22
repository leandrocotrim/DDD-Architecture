using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model.Specification
{
    public class AndSpecification<T> : CompositeSpecificationBase<T>
    {
        public AndSpecification(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        { }

        public override bool IsSatisfiedBy(T obj)
        {
            return Left.IsSatisfiedBy(obj) && Right.IsSatisfiedBy(obj);
        }
    }
}
