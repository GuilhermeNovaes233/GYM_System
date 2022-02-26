using AutoMapper;
using GYM_System.Application.Interfaces;
using GYM_System.Application.ViewModels;
using GYM_System.Domain.Entities;
using GYM_System.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
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

        public  async Task CreateTeacherAsync(TeacherViewModel teacher)
        {
            var vm = _mapper.Map<Teacher>(teacher);

            //TODO - ADICIONAR VALIDAÇÂO SE EXISTE - CPF
            await _teacherRepository.AddAsync(vm);
        }

        public async Task<List<TeacherViewModel>> GetAllTeachersAsync()
        {
            var model = await _teacherRepository.GetAllAsync();

            var vm = _mapper.Map<List<TeacherViewModel>>(model);

            return vm;
        }

        public async Task<TeacherViewModel> GetTeacherByIdAsync(Guid idTeacher)
        {
            var model = await _teacherRepository.GetByIdAsync(idTeacher);

            var vm = _mapper.Map<TeacherViewModel>(model);

            return vm;
        }

        public async Task UpdateTeacherAsync(TeacherViewModel teacherUpdated)
        {
            var teacherOnDb = await _teacherRepository.GetByIdAsync(teacherUpdated.Id);
            if (teacherOnDb is null)
            {
                //TODO - Adicionar mensagem de erro
                return;
            }

            var teacherMapped = _mapper.Map<Teacher>(teacherUpdated);

            await _teacherRepository.UpdateAsync(teacherMapped);
        }

        public async Task DeleteTeacherAsync(Guid id)
        {
            var teacherOnDb = await _teacherRepository.GetByIdAsync(id);
            if (teacherOnDb is null)
            {
                //TODO - Adicionar mensagem de erro
                return;
            }

            await _teacherRepository.RemoveAsync(teacherOnDb);
        }
    }
}
