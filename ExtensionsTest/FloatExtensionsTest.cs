// Copyright 2016 afuzzyllama. All Rights Reserved.
using Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTest
{
    [TestClass]
    public class FloatExtensionsTest
    {
        [TestMethod]
        public void IsAlmostZeroTest()
        {
            Assert.IsTrue((0.0f).IsAlmostZero());
            Assert.IsTrue((0.000000000000000000000000001f).IsAlmostZero());
            Assert.IsTrue((0.01f).IsAlmostZero(0.1f));
            Assert.IsFalse((0.01f).IsAlmostZero());
        }

        [TestMethod]
        public void IsAlmostEqualToTest()
        {
            Assert.IsTrue((0.01f).IsAlmostEqualTo(0.01f));
            Assert.IsTrue((0.01f.IsAlmostEqualTo(0.0100000000000000000001f)));
            Assert.IsTrue((0.01f).IsAlmostEqualTo(0.011f, 0.1f));
            Assert.IsFalse((0.01f).IsAlmostEqualTo(0.011f));
        }
    }
}
