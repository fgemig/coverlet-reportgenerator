namespace Coverlet.Demo.Models
{
    public class Produto
    {
        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }

        public int Id { get; private set; }

        public string Descricao { get; private set; }

        public decimal Valor { get; private set; }
    }
}