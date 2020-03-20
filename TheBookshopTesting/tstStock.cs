using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheBookshopTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();

            Assert.IsNotNull(AStock);
        }
    }
}
