namespace SimpleNotes.Models;

public class LinksModel
{
    public int Id { get; set; }
    
    public string Link { get; set; }
    
    public List<NotesModel> Notes { get; set; }

}