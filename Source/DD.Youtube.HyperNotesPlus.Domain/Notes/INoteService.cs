using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DD.Youtube.HyperNotesPlus.Domain.Notes
{
    public interface INoteService
    {
        Task<Guid> Create(Note note);
        Task<IEnumerable<Note>> GetAllNotes();
        Task<Note> GetNote(Guid id);
        Task Update(Guid id, Note note);
    }
}
