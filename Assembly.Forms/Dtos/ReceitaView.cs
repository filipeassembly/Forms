namespace Assembly.Forms.Dtos;

public class ReceitaView
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Descricao { get; set; }
    public List<IngredienteView> Ingredientes { get; set; }

}
