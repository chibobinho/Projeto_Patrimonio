using Moq;
using Patrimonio.Interfaces;
using Xunit;

namespace Patrimonio.Test.Controllers
{
    public class EquipamentosControllerTest
    {
        [Fact]
        public void DeveRetornarUmEquipamento()
        {
            // Pré-conceito
            var fakerepository = new Mock<IEquipamentoRepository>();
            fakerepository
                .Setup(X => X.Cadastrar(It.IsAny<string>())
                .returns((EquipamentosControllerTest)null));

            // Procedimento


            // Resultado Esperado
        }
    }
}
