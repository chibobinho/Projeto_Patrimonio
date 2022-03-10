using Patrimonio.Domains;
using Xunit;

namespace Patrimonio.Test.Domains
{
    public class UsuarioDomainTests
    {

        [Fact]
        public void DeveRetornarUsuarioPreenchido()
        {
            // Pré-Condição / Arrange
            Usuario usuario = new Usuario();
            usuario.Email = "paulo@email.com";
            usuario.Senha = "$2a$11$IFL28wZvcF/Bs2U5Uy8P4u.9Ea4fXgU2jnUhAe.CSVJ0mznvCOtQu";

            // Procedimento / Act
            bool resultado = true;

            if(usuario.Senha == null || usuario.Email == null)
            {
                resultado = false;
            }

            // Resultado esperado / Assert
            Assert.True(resultado);
        }
    }
}
