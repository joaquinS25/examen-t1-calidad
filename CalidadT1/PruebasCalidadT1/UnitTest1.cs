namespace PruebasCalidadT1
{

    public class Tests
    {
        [Test]
        public void RomanoGeneratorTest()
        {   
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(10);
            Assert.AreEqual("X", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(20);
            Assert.AreEqual("XX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(30);
            Assert.AreEqual("XXX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(38);
            Assert.AreEqual("XXXVIII", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(40);
            Assert.AreEqual("XL", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(48);
            Assert.AreEqual("XLVIII", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(50);
            Assert.AreEqual("L", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(58);
            Assert.AreEqual("LVIII", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(60);
            Assert.AreEqual("LX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(68);
            Assert.AreEqual("LXVIII", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(70);
            Assert.AreEqual("LXX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(78);
            Assert.AreEqual("LXXVIII", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(80);
            Assert.AreEqual("LXXX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(88);
            Assert.AreEqual("LXXXVIII", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(90);
            Assert.AreEqual("XC", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(98);
            Assert.AreEqual("XCVIII", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(100);
            Assert.AreEqual("C", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(110);
            Assert.AreEqual("CX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(120);
            Assert.AreEqual("CXX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(130);
            Assert.AreEqual("CXXX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(140);
            Assert.AreEqual("CXL", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(150);
            Assert.AreEqual("CL", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(160);
            Assert.AreEqual("CLX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(170);
            Assert.AreEqual("CLXX", test);
        }

        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(180);
            Assert.AreEqual("CLXXX", test);
        }






    }
}