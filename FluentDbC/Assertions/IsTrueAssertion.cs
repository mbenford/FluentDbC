using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentDbC.Assertions
{
    public class IsTrueAssertion : Assertion
    {
        public IsTrueAssertion(bool value)
            : base(value)
        {
        }

        public override bool IsValid()
        {
            return Convert.ToBoolean(Value);
        }
    }
}
