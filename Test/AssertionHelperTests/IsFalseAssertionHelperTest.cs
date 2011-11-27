using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FluentDbC.Test
{
    [TestFixture]
    public class IsFalseAssertionHelperTest : BaseAssertionHelperTest
    {
        public IsFalseAssertionHelperTest()
        {
            MethodUnderTest = group => AssertionHelper.IsFalse(group, true);
        }
    }
}
