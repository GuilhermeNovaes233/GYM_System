using GYM_System.Application.ViewModels;
using System;
using System.Threading.Tasks;

namespace GYM_System.Application.Interfaces
{
    public interface ITeacherApplicationService
    {
        Task<TeacherViewModel> GetTeacherById(string id);
    }
}