using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FluentDbC.Test.AssertionHelperTests
{
    [TestFixture]
    public class IsNotNullAssertionHelperTest : BaseAssertionHelperTest
    {
        public IsNotNullAssertionHelperTest()
        {
            MethodUnderTest = group => AssertionHelper.IsNotNull(group, null);
        }
    }

}
