namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, Calculadora.Somar(2, 2));
        }
    }
}