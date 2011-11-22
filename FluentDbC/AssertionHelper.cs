using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentDbC.Assertions;

namespace FluentDbC
{
    public static class AssertionHelper
    {
        public static void Validate(this AssertionGroup group)
        {
            var validator = new AssertionValidator(group);
            validator.Validate();
        }

        public static AssertionGroup IsTrue(this AssertionGroup group, bool value)
        {
            var assertion = new IsTrueAssertion(value);
            group.Add(assertion);

            return group;
        }
    }
}
