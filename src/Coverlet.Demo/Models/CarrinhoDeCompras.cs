using Coverlet.Demo.Interfaces;
using System.Collections.Generic;

namespace Coverlet.Demo.Models
{
    public sealed class CarrinhoDeCompras : ICarrinho
    {
        private readonly IList<Produto> _itens = new List<Produto>();

        public CarrinhoDeCompras(Usuario usuario)
        {
            Usuario = usuario;
        }

        public Usuario Usuario { get; }

        public IEnumerable<Produto> Itens => _itens;

        public void AdicionarItem(Produto produto)
        {
            if (produto != null)
                _itens.Add(produto);
        }
    }
}
