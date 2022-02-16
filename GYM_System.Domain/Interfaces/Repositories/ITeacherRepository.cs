using GYM_System.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_System.Domain.Interfaces.Repositories
{
    public interface ITeacherRepository
    {
        Task<Teacher> GetTeacherById(Guid id);
    }
}
