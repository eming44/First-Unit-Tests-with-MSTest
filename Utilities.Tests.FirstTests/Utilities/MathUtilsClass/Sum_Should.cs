using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstTests.UnitTesting;

namespace Utilities.Tests.FirstTests.Utilities.MathUtilsClass
{
    [TestClass]
    public class Sum_Should
    {
        [TestMethod]
        public void ThrowAnArgumentException_WhenTheListIsNull()
        {
            var mathUtil = new MathUtils();
            Assert.ThrowsException<ArgumentException>(() => mathUtil.Sum(null));
        }
    }
}
