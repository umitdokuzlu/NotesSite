using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class NoteContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PP0P5FV\\MSSQLSERVER01;database=DbNotes;integrated security=true;");
        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteTitle> NoteTitles { get; set; }
    }
}
