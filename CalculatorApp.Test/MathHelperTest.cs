namespace CalculatorApp.Test
{

    public class MathHelperTest
    { 
        MathFormulas _calculator= new MathFormulas();

        [Fact]
        public void ISEvenTest()
        {         

            int x = 1;
            int y = 2;

            var xResult= _calculator.IsEven(x);
            var yResult= _calculator.IsEven(y);

            Assert.False(xResult);
            Assert.True(yResult);


        }

        [Theory]
        [InlineData(5, 3, -2)]
        [InlineData(2,2,0)]
        public void DiffTest(int x, int y, int expectedResult)
        {           
            var result = _calculator.Diff(x, y);
            Assert.Equal(expectedResult, result);
        }
    }
}