using Assembly.Forms.Model.Model;

namespace Assembly.Forms.Contracts
{
    public interface IDatabase
    {
        public List<Receita> Receitas { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
    }
}
