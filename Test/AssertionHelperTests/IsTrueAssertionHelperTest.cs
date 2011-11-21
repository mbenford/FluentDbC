using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FluentDbC.Test
{
    [TestFixture]
    public class IsTrueAssertionHelperTest : BaseAssertionHelperTest
    {
        public IsTrueAssertionHelperTest()
        {
            MethodUnderTest = group => AssertionHelper.IsTrue(group, true);
        }
    }
}
