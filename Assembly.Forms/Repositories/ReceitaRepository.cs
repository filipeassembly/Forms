using Assembly.Forms.Contracts;
using Assembly.Forms.Model;

namespace Assembly.Forms.Repositories
{
    public class ReceitaRepository : Repository<Receita>, IReceitaRepository
    {
        public ReceitaRepository(Database database): base(database)
        {
        }

        public List<Receita> GetAllWithIngredientes()
        {
            throw new NotImplementedException();
        }

        public Receita GetByIdWithIngredientes(int id)
        {
            throw new NotImplementedException();
        }
    }
}
