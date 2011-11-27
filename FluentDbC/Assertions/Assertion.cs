using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentDbC.Assertions
{
    public abstract class Assertion
    {
        public Assertion(object value)
        {
            Value = value;
        }

        public object Value { get; private set; }

        public abstract bool IsValid();
    }
}
