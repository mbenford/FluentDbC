using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentDbC.Assertions
{
    public class IsFalseAssertion : Assertion
    {
        public IsFalseAssertion(bool value)
            : base(value)
        {
        }

        public override bool IsValid()
        {
            return !Convert.ToBoolean(Value);
        }
    }
}
