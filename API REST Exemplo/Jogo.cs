using System.Linq;

namespace API_REST_Exemplo
{
    public class Jogo
    {
        public Jogo (string paramNome)
        {
            this.Id = (DBFake.Tbl_Jogo.OrderByDescending(j => j.Id).FirstOrDefault()?.Id ?? 0) + 1;
            this.Nome = paramNome;
        }
        public int Id { get; private set; }
        public string Nome { get; set; }
    }
}
