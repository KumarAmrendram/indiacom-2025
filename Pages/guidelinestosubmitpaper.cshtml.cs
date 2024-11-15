using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class GuidelinestoSubmitPaper : PageModel
{
    private readonly ILogger<GuidelinestoSubmitPaper> _logger;

    public GuidelinestoSubmitPaper(ILogger<GuidelinestoSubmitPaper> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}