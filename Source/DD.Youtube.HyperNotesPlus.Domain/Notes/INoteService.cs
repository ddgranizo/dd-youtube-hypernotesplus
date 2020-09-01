using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DD.Youtube.HyperNotesPlus.Domain.Notes
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetAllNotes();
    }
}
