namespace SimpleNotes.Models;

public class UserModel
{
    public int Id { get; set; }
    public string password { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    public string Slug { get; set; }

    public List<NotesModel> Notes { get; set; }
        
}