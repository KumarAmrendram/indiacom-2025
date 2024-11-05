using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class ImportantDates : PageModel
{
    private readonly ILogger<ImportantDates> _logger;

    public ImportantDates(ILogger<ImportantDates> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
