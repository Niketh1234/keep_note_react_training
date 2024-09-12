using KeepNote.Models;

namespace KeepNote.Repositories
{
    public class NoteRepository
    {
        public static List<Note> Notes = new List<Note>();

        public static object Note { get; internal set; }
    }
}
