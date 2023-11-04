
using Assembly.Forms.Model.Model;

namespace Assembly.Forms.Contracts;

public interface IReceitaRepository : IRepository<Receita>
{
    List<Receita> GetAllWithIngredientes();
    Receita GetByIdWithIngredientes(int id);
}

