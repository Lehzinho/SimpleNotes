namespace SimpleNotes.Models;

public class NotesModel
{
    public int Id { get; set; }

    public string Title { get; set; }
    
    public string Note { get; set; }

    public UserModel Author { get; set; }

    public List<TagsModel> Tags { get; set; }
    
    public List<LinksModel> Links { get; set; }

}