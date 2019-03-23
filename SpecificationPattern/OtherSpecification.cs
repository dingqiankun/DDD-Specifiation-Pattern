using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    public class NameEqualSpecification : Specification<Product>
    {
        private readonly string _ProductName;


        public NameEqualSpecification(string productName)
        {
            _ProductName = productName;
        }


        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.ProductName == _ProductName;
        }
    }


    public class PriceSpecification : Specification<Product>
    {
        private const double Threshold = 7;


        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.Price >= Threshold;
        }
    }


    public class AmountSpecification : Specification<Product>
    {
        private const double Threshold = 10;


        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.Amount >= Threshold;
        }
    }

}
