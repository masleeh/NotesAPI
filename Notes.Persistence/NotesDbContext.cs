using Microsoft.EntityFrameworkCore;
using Notes.App.Interfaces;
using Notes.Domain;
using Notes.Persistence.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence {
    public class NotesDbContext : DbContext, INotesDbContext {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new NoteConfigurations());

            base.OnModelCreating(builder);
        }
    }
}
