using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class IndexModel : PageModel
{
    public required Project[] Projects { get; set; }
    public required Skill[] Skills { get; set; }

    public void OnGet()
    {
        // Create array of projects
        Projects = new Project[]
        {
            new Project("Hello World in Python", "As described the program prints 'Hello World' in Python", 2025),
            new Project("Calculator App", "A simple calculator application built in C#", 2026),
            new Project("Weather Forecast App", "An app that displays weather forecasts for various cities", 2026),
        };

        // Create array of posts
        Skills = new Skill[]
        {
            new Skill("C#", 3),
            new Skill("Python", 5),
            new Skill("JavaScript", 3),
            new Skill("HTML/CSS", 5),
            new Skill("SQL", 4)
        };
    }
}