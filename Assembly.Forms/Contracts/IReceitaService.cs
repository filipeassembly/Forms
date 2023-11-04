using Assembly.Forms.Dtos;
using Assembly.Forms.Model;

namespace Assembly.Forms.Contracts;

public interface IReceitaService : IService<ReceitaView, Receita>
{
    List<ReceitaView> GetAll();
    ReceitaView GetById(int id);
    ReceitaView Add(ReceitaView entity);
    ReceitaView Update(ReceitaView entity);
    ReceitaView Delete(ReceitaView entity);
    ReceitaView Delete(int id);
}
