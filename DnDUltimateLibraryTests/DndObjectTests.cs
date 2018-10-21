using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DnDUltimateLibrary;
using DnDUltimateLibrary.factories;

namespace DnDUltimateLibraryTests
{
    public class DndObjectTests
    {
        Factory factory = new Factory();
        [Fact]
        public void DnDObjectIntegrityTest()
        {
            IDnDObject dnDObject = factory.CreateDnDObject();
            Assert.NotNull(dnDObject.AC);
            Assert.NotNull(dnDObject.HP);
            Assert.NotNull(dnDObject.PhysicalProperties);
            Assert.NotNull(dnDObject.Resistance);
        }
    }
}
