using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Note:IEntity
    {
        [Key]
        public int NoteId { get; set; }
        public string NoteDescription { get; set; }
        public int NoteTitleId { get; set; }
        public NoteTitle NoteTitle { get; set; }
        public bool Status { get; set; }
    }
}
