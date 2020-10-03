namespace Coverlet.Demo.Models
{
    public class Usuario
    {
        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }
    }
}
