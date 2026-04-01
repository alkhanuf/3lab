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
            Volume volume = new Volume(1, VolumeType.m3);
            Assert.AreEqual(new Volume(1000, VolumeType.l), volume.To(VolumeType.l));
            Assert.AreEqual(new Volume(1000000, VolumeType.ml), volume.To(VolumeType.ml));
            Assert.AreEqual(new Volume(6.289822, VolumeType.barr), volume.To(VolumeType.barr));

            volume = new Volume(1, VolumeType.l);
            Assert.AreEqual(new Volume(0.001, VolumeType.m3), volume.To(VolumeType.m3));
            Assert.AreEqual(new Volume(1000, VolumeType.ml), volume.To(VolumeType.ml));

            volume = new Volume(1, VolumeType.barr);
            Assert.AreEqual(new Volume(158.987, VolumeType.l), volume.To(VolumeType.l));
            Assert.AreEqual(new Volume(0.158987, VolumeType.m3), volume.To(VolumeType.m3));

            volume = new Volume(1000, VolumeType.ml);
            Assert.AreEqual(new Volume(1, VolumeType.l), volume.To(VolumeType.l));
            Assert.AreEqual(new Volume(0.001, VolumeType.m3), volume.To(VolumeType.m3));
        }

        [TestMethod]
        public void Equals()
        {
            var v1 = new Volume(1, VolumeType.m3);
            var v2 = new Volume(1000, VolumeType.l);
            var v3 = new Volume(2, VolumeType.m3);

            Assert.IsTrue(v1 == v2);
            Assert.IsFalse(v1 == v3);
        }

        [TestMethod]
        public void NotEquals()
        {
            var v1 = new Volume(1, VolumeType.m3);
            var v2 = new Volume(1000, VolumeType.l);
            var v3 = new Volume(2, VolumeType.m3);

            Assert.IsFalse(v1 != v2);
            Assert.IsTrue(v1 != v3);
        }

        [TestMethod]
        public void Сomparison()
        {
            var v1 = new Volume(1, VolumeType.m3);
            var v2 = new Volume(500, VolumeType.l);
            var v3 = new Volume(1500, VolumeType.l);

            Assert.IsTrue(v1 > v2);
            Assert.IsTrue(v3 > v1);
            Assert.IsTrue(v2 < v1);
        }

        [TestMethod]
        public void AddNumber()
        {
            var volume = new Volume(5, VolumeType.l);
            var result1 = volume + 3;
            var result2 = 3 + volume;

            Assert.AreEqual(new Volume(8, VolumeType.l), result1);
            Assert.AreEqual(new Volume(8, VolumeType.l), result2);
        }

        [TestMethod]
        public void SubNumber()
        {
            var volume = new Volume(10, VolumeType.l);
            var result1 = volume - 2.5;
            var result2 = 5 - volume;

            Assert.AreEqual(new Volume(7.5, VolumeType.l), result1);
            Assert.AreEqual(new Volume(-5, VolumeType.l), result2);
        }

        [TestMethod]
        public void MulNumber()
        {
            var volume = new Volume(3, VolumeType.m3);
            var result1 = volume * 4;
            var result2 = 2 * volume;

            Assert.AreEqual(new Volume(12, VolumeType.m3), result1);
            Assert.AreEqual(new Volume(6, VolumeType.m3), result2);
        }

        [TestMethod]
        public void DivNumber()
        {
            var volume = new Volume(15, VolumeType.l);
            var result1 = volume / 3;
            var result2 = 30 / volume;

            Assert.AreEqual(new Volume(5, VolumeType.l), result1);
            Assert.AreEqual(new Volume(2, VolumeType.l), result2);
        }

        [TestMethod]
        public void AddVolumes()
        {
            var m3 = new Volume(1, VolumeType.m3);
            var l = new Volume(500, VolumeType.l);
            var ml = new Volume(500000, VolumeType.ml);

            Assert.AreEqual(new Volume(1.5, VolumeType.m3), m3 + l);
            Assert.AreEqual(new Volume(1500, VolumeType.l), l + m3);
            Assert.AreEqual(new Volume(1000000, VolumeType.ml), ml + l);
        }

        [TestMethod]
        public void SubVolumes()
        {
            var m3 = new Volume(2, VolumeType.m3);
            var l = new Volume(500, VolumeType.l);

            Assert.AreEqual(new Volume(1.5, VolumeType.m3), m3 - l);
            Assert.AreEqual(new Volume(-1500, VolumeType.l), l - m3);
        }
    }
}