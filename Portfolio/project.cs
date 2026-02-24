namespace Portfolio;

public class Project
{
    public string Title { get; set; }
    public string Description { get; set; }    
    public int Year { get; set; }

    public Project(string title, string description, int year) // Constructor to initialize the project properties
    {
        Title = title;
        Description = description;
        Year = year;
    }
}