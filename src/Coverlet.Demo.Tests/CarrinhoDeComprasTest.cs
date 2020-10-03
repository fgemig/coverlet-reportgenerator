using Coverlet.Demo.Models;
using System.Linq;
using Xunit;

namespace Coverlet.Demo.Tests
{
    public class CarrinhoDeComprasTest
    {
        [Fact]
        public void CarrinhoDeComprasDeveTerUmUsuario()
        {
            Usuario usuario = new Usuario(1, "Fabio");

            CarrinhoDeCompras carrinhoDeCompras = new CarrinhoDeCompras(usuario);

            Usuario usuarioCarrinho = carrinhoDeCompras.Usuario;

            Assert.Equal(1, usuarioCarrinho.Id);
            Assert.Equal("Fabio", usuarioCarrinho.Nome);
        }

        [Fact]
        public void CarrinhoDeComprasDeveTerUmProduto()
        {
            Usuario usuario = new Usuario(1, "Fabio");

            CarrinhoDeCompras carrinhoDeCompras = new CarrinhoDeCompras(usuario);

            Produto produto = new Produto(1, "Fender Stratocaster", 12000);

            carrinhoDeCompras.AdicionarItem(produto);

            Produto produtoCarrinho = carrinhoDeCompras.Itens.First();

            Assert.Equal(1, produtoCarrinho.Id);
            Assert.Equal("Fender Stratocaster", produtoCarrinho.Descricao);
            Assert.Equal(12000, produtoCarrinho.Valor);
        }
    }
}
