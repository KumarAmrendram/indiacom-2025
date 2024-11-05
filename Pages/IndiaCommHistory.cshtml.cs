using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class IndiaCommHistory : PageModel
{
    private readonly ILogger<IndiaCommHistory> _logger;

    public IndiaCommHistory(ILogger<IndiaCommHistory> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
