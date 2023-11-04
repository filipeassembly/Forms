using Assembly.Forms.Contracts;
using Assembly.Forms.Model.Model;

namespace Assembly.Forms.Repositories
{
    public class IngredienteRepository : Repository<Ingrediente>, IIngredienteRepository
    {
        public IngredienteRepository(Database database) : base(database)
        {
        }
    }
}
