using Patrimonio.Utils;
using System.Text.RegularExpressions;
using Xunit;

namespace Patrimonio.Test.Utils
{
    public class CriptografiaTests
    {
        [Fact]
        public void DeveRetornarHashEmBCrypt()
        {
            // Pré-condição
            var senha = Criptografia.GerarHash("123456789");
            var regex = new Regex(@"^\$2[ayb]\$.{56}$");

            // Procedimento
            var retorno = regex.IsMatch(senha);

            // Resultado esperado
            Assert.True(retorno);
        }

        [Fact]
        public void DeveRetornarComparacaoValida()
        {
            // Pré-condição (FALTA ARRUMAR PQ A SENHA TA EM HASH)
            var senha = "123456789";
            var hash = "$2a$11$IFL28wZvcF/Bs2U5Uy8P4u.9Ea4fXgU2jnUhAe.CSVJ0mznvCOtQu";

            //Procedimento
            var comparacao = Criptografia.Comparar(senha, hash);

            // Resultado esperado
            Assert.True(comparacao);
        }
    }
}
