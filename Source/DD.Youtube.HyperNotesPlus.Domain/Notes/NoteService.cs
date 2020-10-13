using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DD.Youtube.HyperNotesPlus.Domain.Notes
{
    public class NoteService : INoteService
    {
        public NoteService()
        {
        }

        public async Task<Note> GetNote(Guid id)
        {
            await Task.Delay(200);
            return new Note()
            {
                Id = id,
                Content = "TestContent",
                Name = "Name test",
                State = Common.Definitions.StateEnum.Enabled,
                CreatedOn = DateTime.Now,
            };
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            await Task.Delay(200);
            return new List<Note>()
            {
                {new Note{ Id = Guid.NewGuid(), Name = "Nota1", Content = "Contenido nota 1", State = Domain.Common.Definitions.StateEnum.Enabled }},
                {new Note{ Id = Guid.NewGuid(), Name = "Nota2", Content = "Contenido nota 2", State = Domain.Common.Definitions.StateEnum.Disabled }},
                {new Note{ Id = Guid.NewGuid(), Name = "Nota3", Content = "Contenido nota 3", State = Domain.Common.Definitions.StateEnum.Enabled }},
            };
        }
    }
}
