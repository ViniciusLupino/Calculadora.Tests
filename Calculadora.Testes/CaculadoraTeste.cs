namespace Calculadora.Testes
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, CalculadoraExample.Calculadora.Somar(2, 2));
        }
        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, CalculadoraExample.Calculadora.Subtrair(2, 2));
        }
        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(4, CalculadoraExample.Calculadora.Multiplicar(2, 2));
        }
        [Fact]
        public void Dividir()
        {
            Assert.Equal(0, CalculadoraExample.Calculadora.Dividir(0, 0));
        }
        [Fact]
        public void Bhaskara()
        {
            Assert.Equal([1, -4], CalculadoraExample.Calculadora.Bhaskara(1, 3, -4));
        }
    }
}