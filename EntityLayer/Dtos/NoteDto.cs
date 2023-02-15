using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos
{
    public class NoteDto:IEntity
    {
        public int NoteId { get; set; }
        public string NoteDescription { get; set; }
        public NoteTitle NoteTitle { get; set; }
        public bool Status { get; set; }
    }
}
