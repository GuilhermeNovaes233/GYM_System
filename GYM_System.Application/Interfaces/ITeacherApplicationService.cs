using GYM_System.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GYM_System.Application.Interfaces
{
    public interface ITeacherApplicationService
    {
        Task<TeacherViewModel> GetTeacherByIdAsync(Guid id);
        Task<List<TeacherViewModel>> GetAllTeachersAsync();
        Task CreateTeacherAsync(TeacherViewModel teacherUpdated);
        Task UpdateTeacherAsync(TeacherViewModel teacherUpdated);
        Task DeleteTeacherAsync(Guid id);
    }
}