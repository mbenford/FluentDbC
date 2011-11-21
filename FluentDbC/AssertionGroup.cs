using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using FluentDbC.Assertions;

namespace FluentDbC
{
    public class AssertionGroup : IEnumerable<Assertion>
    {
        private IList<Assertion> assertions;

        public AssertionGroup()
        {
            assertions = new List<Assertion>();
        }        

        public void Add(Assertion assertion)
        {
            assertions.Add(assertion);
        }

        public IEnumerator<Assertion> GetEnumerator()
        {
            return assertions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return assertions.GetEnumerator();
        }
    }
}
