using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FluentDbC.Test
{
    [TestFixture]
    public class IsNullAssertionHelperTest : BaseAssertionHelperTest
    {
        public IsNullAssertionHelperTest()
        {
            MethodUnderTest = group => AssertionHelper.IsNull(group, null);
        }
    }
}
