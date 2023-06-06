namespace SimpleNotes.Models;

public class TagsModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<NotesModel> Notes { get; set; }


}