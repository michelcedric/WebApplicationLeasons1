using App.Domain;
using System.Data.Entity;

namespace App.Data
{
    public class Leasons1Context : DbContext
    {
        public Leasons1Context() : base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
