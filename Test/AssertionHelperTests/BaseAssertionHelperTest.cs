using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FluentDbC.Test
{
    
    public abstract class BaseAssertionHelperTest
    {
        protected Func<AssertionGroup, AssertionGroup> MethodUnderTest { get; set; }

        [Test]
        public void Retuns_Same_Assertion_Group()
        {
            // Arrange
            var initialGroup = new AssertionGroup();

            // Act
            AssertionGroup group = MethodUnderTest(initialGroup);

            // Assert
            Assert.AreSame(initialGroup, group);
        }

        [Test]
        public void Creates_Assertion_And_Adds_It_To_The_Group()
        {
            // Arrange
            var group = new AssertionGroup();

            // Act
            MethodUnderTest(group);

            // Assert
            Assert.IsNotNull(group.Last());
        }
    }
}
