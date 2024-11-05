using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class SpecialSessions : PageModel
{
    private readonly ILogger<SpecialSessions> _logger;

    public SpecialSessions(ILogger<SpecialSessions> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
