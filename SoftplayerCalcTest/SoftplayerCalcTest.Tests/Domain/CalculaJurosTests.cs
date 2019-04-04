using SoftplayerCalcTest.Domain;
using Xunit;

namespace SoftplayerCalcTest.Tests.Domain
{
    //Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final = Valor Inicial* (1 + juros) ^ Tempo
    //Valor inicial é um decimal recebido como parâmetro Juros é 1% ou 0,01 (fixo no código) Tempo é um inteiro, que representa meses, 
    //também recebido como parâmetro ^ representa a operação de potência Resultado final deve ser truncado(sem arredondamento) 
    //em duas casas decimais Exemplo: /calculajuros? valorinicial = 100 & meses = 5 Resultado esperado: 105,10
    public class CalculaJurosTests
    {
        [Fact]
        public void CalculoJurosCompostosTests()
        {
            var calculator = new Calculador(100,5);
            var resultado = calculator.ValorFinal();
            Assert.Equal(105.10M, resultado);
        }
    }
}
