using Assembly.Forms.Contracts;
using Assembly.Forms.Dtos;
using Assembly.Forms.Exceptions;
using Assembly.Forms.Model.Model;

namespace Assembly.Forms.Services;

public class ReceitaService : IReceitaService
{
    private readonly IReceitaRepository _receitaRepository;

    public ReceitaService(IReceitaRepository receitaRepository)
    {
        this._receitaRepository = receitaRepository;
    }

    public ReceitaView Add(ReceitaView entity)
    {
        // Validações
        if(entity.Title is null || entity.Title.Length <= 3)
        {
            throw new TitleServiceException("Title must be not null and above 3 chars long");
        }

        if(entity.Id != 0)
        {

        }

        // Meapeamento ReceitaView => Receita 
        Receita receita = new Receita(entity.Title, entity.Descricao)
        {
            Ingredientes = new List<Ingrediente>()
        };

        foreach (var ingredienteView in entity.Ingredientes)
        {
            // Meapeamento IngredienteView => Ingrediente
            receita.Ingredientes.Add(new Ingrediente()
            {
                Produto = ingredienteView.Produto,
                Quantidade = ingredienteView.Quantidade,
                Unidade = ingredienteView.Unidade,
            });
        }

        receita = _receitaRepository.Add(receita);

        // Meapeamento Receita => ReceitaView
        var receitaToReturn = new ReceitaView()
        {
            Id = receita.Id,
            Title = receita.Titulo,
            Descricao = receita.Descricao,
            Ingredientes = new List<IngredienteView>()
        };

        foreach (var ingrediente in receita.Ingredientes)
        {
            // Meapeamento Ingrediente => IngredienteView
            receitaToReturn.Ingredientes.Add(new IngredienteView()
            {
                Produto = ingrediente.Produto,
                Quantidade = ingrediente.Quantidade,
                Unidade = ingrediente.Unidade,
            });
        }

        return receitaToReturn;
    }

    public ReceitaView Delete(ReceitaView entity)
    {
        throw new NotImplementedException();
    }

    public ReceitaView Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<ReceitaView> GetAll()
    {
        throw new NotImplementedException();
    }

    public ReceitaView GetById(int id)
    {
        throw new NotImplementedException();
    }

    public ReceitaView Update(ReceitaView entity)
    {
        throw new NotImplementedException();
    }
}