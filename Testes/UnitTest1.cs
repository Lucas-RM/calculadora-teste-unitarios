using NewTalents;
using System;
using Xunit;

namespace TestwNewTalents
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calculadora = new Calculadora(data);

            return calculadora;
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            // Arrage
            Calculadora calculadora = construirClasse();

            // Act
            int resultadoCalculadora = calculadora.somar(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(14, 5, 9)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            // Arrage
            Calculadora calculadora = construirClasse();

            // Act
            int resultadoCalculadora = calculadora.subtrair(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            // Arrage
            Calculadora calculadora = construirClasse();

            // Act
            int resultadoCalculadora = calculadora.multiplicar(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(45, 5, 9)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            // Arrage
            Calculadora calculadora = construirClasse();

            // Act
            int resultadoCalculadora = calculadora.dividir(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            // Arrage
            Calculadora calculadora = construirClasse();

            // Act / Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            // Arrage
            Calculadora calculadora = construirClasse();

            // Act 
            calculadora.somar(1, 2);
            calculadora.somar(2, 8);
            calculadora.somar(3, 7);
            calculadora.somar(4, 1);

            var lista = calculadora.historico();

            // Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
