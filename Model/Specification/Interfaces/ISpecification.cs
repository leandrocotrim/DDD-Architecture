using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model.Specification
{
    public interface ISpecification<T>
    {
        //Expression<Func<T, bool>> SpecExpression { get; }

        bool IsSatisfiedBy(T obj);
    }
}
