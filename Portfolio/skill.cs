namespace Portfolio;

public class Skill
{
    public string Name { get; set; }
    public int ProficiencyLevel { get; set; }    

    public Skill(string name, int proficiencylevel) // Constructor to initialize the skill properties
    {
        Name = name;
        ProficiencyLevel = proficiencylevel;
    }
}