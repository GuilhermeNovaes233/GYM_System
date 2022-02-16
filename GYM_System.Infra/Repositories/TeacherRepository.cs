using GYM_System.Domain.Entities;
using GYM_System.Domain.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace GYM_System.Infra.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public Task<Teacher> GetTeacherById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}