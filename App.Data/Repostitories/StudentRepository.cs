using App.Data.Interfaces;
using App.Domain;

namespace App.Data.Repostitories
{
    public class StudentRepository : EFRepository<Student>, IStudentRepository
    {
        public StudentRepository(Leasons1Context dbContext) : base(dbContext)
        {
        }
    }
}
