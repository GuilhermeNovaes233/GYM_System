using AutoMapper;
using GYM_System.Application.Interfaces;
using GYM_System.Application.ViewModels;
using GYM_System.Domain.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace GYM_System.Application.Services
{
    public class TeacherApplicationService : ITeacherApplicationService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public TeacherApplicationService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<TeacherViewModel> GetTeacherById(string id)
        {
            var model = await _teacherRepository.GetByIdAsync(new Guid(id));

            var vm = _mapper.Map<TeacherViewModel>(model);

            return vm;
        }
    }
}
