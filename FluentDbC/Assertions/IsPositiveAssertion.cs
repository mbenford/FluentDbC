using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentDbC.Assertions
{
    public class IsPositiveAssertion : FluentDbC.Assertions.Assertion
    {
        public IsPositiveAssertion(object value)
            : base(value)
        {
        }

        public override bool IsValid()
        {
            int result = (Value as IComparable).CompareTo(0);
            return result > 0;
        }
    }
}
