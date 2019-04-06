using SoftplayerCalcTest.Api.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace SoftplayerCalcTest.Tests.UnitTests.Controllers
{
    public class ValuesControllerTests
    {
        [Fact]
        public void DeveRetornoValorFinal()
        {
            var controller = new ValuesController();
            const decimal valorInicial = 100M;
            const int meses = 5;

            var retorno = controller.Get(valorInicial, meses) as OkObjectResult;

            Assert.Equal(200, retorno?.StatusCode);
            Assert.Equal(105.10M, retorno?.Value);

        }

        [Fact]
        public void DeveRetornarLink()
        {
            var controller = new ValuesController();

            var retorno = controller.Get();

            Assert.Equal("https://github.com/rodrigodosanjosoliveira/SoftplayerCalcTest.git", retorno.Value);
        }
    }
}
