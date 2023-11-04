using Assembly.Forms.Contracts;
using Assembly.Forms.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assembly.Forms.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IReceitaService _receitaService;

    public IndexModel(IReceitaService receitaService)
    {
        this._receitaService = receitaService;
    }

    [BindProperty]
    public ReceitaView Receita { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost() 
    {
        // Fat vs Thin Controllers
        _receitaService.Add(Receita);
    }
}