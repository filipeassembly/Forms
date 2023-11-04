using Assembly.Forms.Contracts;
using Assembly.Forms.Model;

namespace Assembly.Forms.Repositories
{
    public class Database : IDatabase
    {
        public List<Receita> Receitas { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
    }
}
