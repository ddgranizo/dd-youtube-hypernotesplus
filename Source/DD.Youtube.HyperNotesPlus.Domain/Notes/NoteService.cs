using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.Youtube.HyperNotesPlus.Domain.Notes
{
    public class NoteService : INoteService
    {
        public List<Note> Notes { get; set; }

        public NoteService()
        {
            Notes = new List<Note>();
        }

        public async Task<Guid> Create(Note note)
        {
            note.Id = Guid.NewGuid();
            note.State = Common.Definitions.StateEnum.Enabled;
            Notes.Add(note);
            await Task.Delay(200);
            return note.Id;
        }

        public async Task Update(Guid id, Note note)
        {
            await Task.Delay(200);
            var noteInList = Notes.FirstOrDefault(k => k.Id == id)
                ?? throw new ArgumentOutOfRangeException($"Can't find record with Id={id}");
            var index = Notes.IndexOf(noteInList);
            Notes[index] = note;
        }


        public async Task<Note> GetNote(Guid id)
        {
            await Task.Delay(200);
            var note = Notes.FirstOrDefault(k => k.Id == id)
                ?? throw new ArgumentOutOfRangeException($"Can't find record with Id={id}");
            return note;
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            await Task.Delay(200);
            return Notes;
        }
    }
}
