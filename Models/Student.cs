namespace aspnetWebApp.Models;

public class IndexModel : PageModel
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string Speciality { get; set; } = "";
    public string Course { get; set; } = "";
    public string BirthDate { get; set; } = "";
    public string[] Technologies { get; set; } = Array.Empty<string>();
}