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
            Assert.AreEqual("10 б", volume4.Verbose());
        }

        [TestMethod]
        public void ConversionTest()
        {
            var volume = new Volume(1, VolumeType.m3);
            Assert.AreEqual("1000 л", volume.To(VolumeType.l).Verbose());
            Assert.AreEqual("1000000 мл", volume.To(VolumeType.ml).Verbose());
            Assert.AreEqual("6,289822 б", volume.To(VolumeType.barr).Verbose());

            volume = new Volume(1, VolumeType.l);
            Assert.AreEqual("0,001 м3", volume.To(VolumeType.m3).Verbose());
            Assert.AreEqual("1000 мл", volume.To(VolumeType.ml).Verbose());

            volume = new Volume(1, VolumeType.barr);
            Assert.AreEqual("158,987 л", volume.To(VolumeType.l).Verbose());
            Assert.AreEqual("0,158987 м3", volume.To(VolumeType.m3).Verbose());

            volume = new Volume(1000, VolumeType.ml);
            Assert.AreEqual("1 л", volume.To(VolumeType.l).Verbose());
            Assert.AreEqual("0,001 м3", volume.To(VolumeType.m3).Verbose());
        }

    }
}
