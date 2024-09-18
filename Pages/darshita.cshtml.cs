using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class DarshitaModel : PageModel
{
    private readonly ILogger<DarshitaModel> _logger;

    public DarshitaModel(ILogger<DarshitaModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
