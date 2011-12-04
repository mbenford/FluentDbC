using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentDbC.Assertions
{
    public class IsNotNullAssertion : Assertion
    {
        public IsNotNullAssertion(object value)
            : base(value)
        {
        }

        public override bool IsValid()
        {
            return Value != null;
        }
    }
}
