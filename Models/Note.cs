namespace KeepNote.Models
{
    public class Note : INote
    {
        public int NoteId { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public string NoteStatus { get; set; }
        public DateTime CreatedAt
        {
            get { return DateTime.Now.Date; }
        }

    }
}
