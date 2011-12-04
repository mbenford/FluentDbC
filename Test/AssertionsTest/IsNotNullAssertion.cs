using System;
using System.Collections.Generic;
using System.Linq;
using FluentDbC.Assertions;

namespace FluentDbC.Test.AssertionsTest
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
