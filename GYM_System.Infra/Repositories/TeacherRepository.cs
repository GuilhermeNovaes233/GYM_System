using GYM_System.Domain.Entities;
using GYM_System.Domain.Interfaces.Repositories;
using GYM_System.Infra.Data;

namespace GYM_System.Infra.Repositories
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DataContext context) : base(context) {}

    }
}