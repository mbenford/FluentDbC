using System;
using System.Collections.Generic;
using System.Linq;
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
            group.Add(new IsTrueAssertion(value));
            return group;
        }

        public static AssertionGroup IsFalse(this AssertionGroup group, bool value)
        {
            group.Add(new IsFalseAssertion(value));
            return group;
        }

        public static AssertionGroup IsNull(this AssertionGroup group, object value)
        {
            group.Add(new IsNullAssertion(value));
            return group;
        }
    }
}
