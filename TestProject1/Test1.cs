using _3lab;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void VerboseTest()
        {
            var volume1 = new Volume(10, VolumeType.m3);
            Assert.AreEqual("10 м3", volume1.Verbose());

            var volume2 = new Volume(200, VolumeType.ml);
            Assert.AreEqual("200 мл", volume2.Verbose());

            var volume3 = new Volume(10, VolumeType.l);
            Assert.AreEqual("10 л", volume3.Verbose());

            var volume4 = new Volume(10, VolumeType.barr);
            Assert.AreEqual("10 барр", volume4.Verbose());
        }
    }
}
