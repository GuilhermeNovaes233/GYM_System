using GYM_System.Application.Interfaces;
using GYM_System.Application.ViewModels;
using GYM_System.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GYM_System.Application.Services
{
    public class TeacherApplicationService : ITeacherApplicationService
    {
        private readonly ITeacherRepository _teacherRepository;
        
        public TeacherApplicationService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<TeacherViewModel> GetTeacherById(string id)
        {
            var result = await _teacherRepository.GetTeacherById(new Guid(id));

            //TODO - Adicionar mapper

            throw new NotImplementedException();
        }
    }
}
