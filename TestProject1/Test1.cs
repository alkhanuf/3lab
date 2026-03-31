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

            Assert.AreEqual("8 л", result1.Verbose());
            Assert.AreEqual("8 л", result2.Verbose());
        }

        [TestMethod]
        public void SubNumber()
        {
            var volume = new Volume(10, VolumeType.l);
            var result1 = volume - 2.5;
            var result2 = 5 - volume;

            Assert.AreEqual("7,5 л", result1.Verbose());
            Assert.AreEqual("-5 л", result2.Verbose());
        }

        [TestMethod]
        public void MulNumber()
        {
            var volume = new Volume(3, VolumeType.m3);
            var result1 = volume * 4;
            var result2 = 2 * volume;

            Assert.AreEqual("12 м3", result1.Verbose());
            Assert.AreEqual("6 м3", result2.Verbose());
        }

        [TestMethod]
        public void DivNumber()
        {
            var volume = new Volume(15, VolumeType.l);
            var result1 = volume / 3;
            var result2 = 30 / volume;

            Assert.AreEqual("5 л", result1.Verbose());
            Assert.AreEqual("2 л", result2.Verbose());
        }

        [TestMethod]
        public void AddVolumes()
        {
            var m3 = new Volume(1, VolumeType.m3);
            var l = new Volume(500, VolumeType.l);
            var ml = new Volume(500000, VolumeType.ml);

            Assert.AreEqual("1,5 м3", (m3 + l).Verbose());
            Assert.AreEqual("1500 л", (l + m3).Verbose());
            Assert.AreEqual("1000000 мл", (ml + l).Verbose());
        }

        [TestMethod]
        public void SubVolumes()
        {
            var m3 = new Volume(2, VolumeType.m3);
            var l = new Volume(500, VolumeType.l);

            Assert.AreEqual("1,5 м3", (m3 - l).Verbose());
            Assert.AreEqual("-1500 л", (l - m3).Verbose());
        }

    }
}
