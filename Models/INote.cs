
namespace KeepNote.Models
{
    public interface INote
    {
        DateTime CreatedAt { get; }
        string NoteContent { get; set; }
        int NoteId { get; set; }
        string NoteStatus { get; set; }
        string NoteTitle { get; set; }
    }
}