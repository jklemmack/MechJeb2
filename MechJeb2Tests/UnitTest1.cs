using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MuMech;

namespace MechJeb2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = new DebugIcoSphere(UnityEngine.Color.red, true);
        }
    }
}
