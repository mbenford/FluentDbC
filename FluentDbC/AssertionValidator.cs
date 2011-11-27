using System;
using System.Collections.Generic;
using System.Linq;
using FluentDbC.Assertions;

namespace FluentDbC
{
    public class AssertionValidator
    {
        private readonly AssertionGroup group;

        public AssertionValidator(AssertionGroup group)
        {
            this.group = group;
        }

        public void Validate()
        {
            foreach (Assertion assertion in group)
            {
                if (!assertion.IsValid())
                    throw new AssertionInvalidException();
            }
        }
    }
}
