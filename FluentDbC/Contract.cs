using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentDbC
{
    public static class Contract
    {
        public static AssertionGroup Begin()
        {
            return new AssertionGroup();
        }
    }
}