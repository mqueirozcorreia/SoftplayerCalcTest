using System;
using SoftplayerCalcTest.Domain;
using Xunit;

namespace SoftplayerCalcTest.Tests.Domain
{
    public class CalculaJurosTests
    {
        [Fact]
        public void CalculoJurosCompostosTests()
        {
            var calculator = new Calculador(100,5);
            var resultado = calculator.ValorFinal();
            Assert.Equal(105.10M, resultado);
        }

        [Fact]
        public void CalculoJurosCompostosIdGuidNotEmpty()
        {
            var calculador = new Calculador(100,5);

            Assert.NotEqual(Guid.Empty, calculador.Id);
        }
    }
}
