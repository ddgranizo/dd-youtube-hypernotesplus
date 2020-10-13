using System;
using System.Collections.Generic;
using System.Text;
using static DD.Youtube.HyperNotesPlus.Domain.Common.Definitions;

namespace DD.Youtube.HyperNotesPlus.Domain.Notes
{
    public class Note
    {
        public Note()
        {
            
        }


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public StateEnum State { get; set; }
    }
}
