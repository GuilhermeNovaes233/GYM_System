using GYM_System.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GYM_System.Application.Interfaces
{
    public interface ITeacherApplicationService
    {
        Task<TeacherViewModel> GetTeacherByIdAsync(string id);
        Task<List<TeacherViewModel>> GetAllTeachersAsync();
        Task CreateTeacherAsync(TeacherViewModel model);
        Task UpdateTeacherAsync(TeacherViewModel model);
        Task DeleteTeacherAsync(string id);
    }
}