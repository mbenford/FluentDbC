using System;
using System.Collections.Generic;
using System.Linq;
using FluentDbC.Assertions;

namespace FluentDbC.Assertions
{
    public class IsNullAssertion : Assertion
    {
        public IsNullAssertion(object value)
            : base(value)
        {
        }

        public override bool IsValid()
        {
            return Value == null;
        }
    }
}
