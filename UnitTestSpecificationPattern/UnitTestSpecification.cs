using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecificationPattern;

using Shouldly;

namespace UnitTestSpecificationPattern
{
    [TestClass]
    public class UnitTestSpecification
    {
        [TestMethod]
        public void TestAndSpecification()
        {
            var product = new Product { ProductName = "p2", Amount=10, Price=11.3 };
            var nameSpec = new NameEqualSpecification("p1");
            var amountSpec = new AmountSpecification();
            var priceSpec = new PriceSpecification();
            var andSpec = nameSpec.And(amountSpec).And(priceSpec);

            bool isSatisfiedBy = andSpec.IsSatisfiedBy(product);
            isSatisfiedBy.ShouldBeTrue();
        }
    }
}
