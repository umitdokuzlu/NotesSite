using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NoteTitle:IEntity
    {
        [Key]
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public List<Note> Notes { get; set; }
    }
}
