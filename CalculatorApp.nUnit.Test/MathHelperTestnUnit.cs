namespace CalculatorApp.nUnit.Test
{
    public class MathHelperTestnUnit
    {
        MathFormulas _mathFormulas { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _mathFormulas = new MathFormulas();
        }

        [Test]
        public void AddTest()
        {
            int x = 10;
            int y= 20;
            int expected = 30;
            int result = _mathFormulas.Add(x, y);
            Assert.AreEqual(expected, result);

        }
        [Test]
        public void DiffTest()
        {
            int x = 10;
            int y = 20;
            int expectedResult = 10;
            var result = _mathFormulas.Diff(x, y);
            Assert.AreEqual(expectedResult, result);
        }
    }
}