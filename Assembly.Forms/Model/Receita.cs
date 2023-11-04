using Assembly.Forms.Exceptions;

namespace Assembly.Forms.Model;

public class Receita
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public List<Ingrediente> Ingredientes { get; set; }

    public Receita(string titulo, string descricao)
    {
        if(titulo is null || titulo.Length <= 3)
        {
            throw new TitleDomainException("Title can't be null or less than 3 chars");
        }
        Titulo = titulo;
        Descricao = descricao;
    }
}