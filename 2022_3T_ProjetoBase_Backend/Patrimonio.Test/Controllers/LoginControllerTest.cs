using Microsoft.AspNetCore.Mvc;
using Moq;
using Patrimonio.Controllers;
using Patrimonio.Domains;
using Patrimonio.Interfaces;
using Patrimonio.ViewModels;
using Xunit;

namespace Patrimonio.Test.Controllers
{
    public class LoginControllerTest
    {
        [Fact]
        public void DeveRetornarUmUsuarioInvalido()
        {
            // Pré-Condição
            var fakerepository = new Mock<IUsuarioRepository>();
            fakerepository
                .Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((Usuario)null);

            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.Email = "tsuka@email.com";
            loginViewModel.Senha = "123456789";

            var controller = new LoginController(fakerepository.Object);

            // Procedimento
            var resultado = controller.Login(loginViewModel);

            // Resultado Esperado
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }

        [Fact]
        public void DeveRetornarUmUsuarioValido()
        {
            // Pré-Condição
            var usuarioFake = new Usuario();
            usuarioFake.Email = "tsuka@email.com";
            usuarioFake.Senha = "$2a$11$hiZbWL24AUJwHz9I/JqH7u9sdd6i03bvEOBXTXcrbRNYpCMRgg64y";

            var fakerepository = new Mock<IUsuarioRepository>();
            fakerepository
                .Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(usuarioFake);

            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.Email = "tsuka@email.com";
            loginViewModel.Senha = "123456789";

            var controller = new LoginController(fakerepository.Object);

            // Procedimento
            var resultado = controller.Login(loginViewModel);

            // Resultado Esperado
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }
    }
}
