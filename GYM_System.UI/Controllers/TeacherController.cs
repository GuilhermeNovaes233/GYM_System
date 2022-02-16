using GYM_System.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM_System.UI.Controllers
{
    [Route("Teacher")]
    public class TeacherController : Controller
    {
        private readonly ITeacherApplicationService _teacherApplicationService;

        public TeacherController(ITeacherApplicationService teacherApplicationService)
        {
            _teacherApplicationService = teacherApplicationService;
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById([FromQuery] string teacherId)
            => Ok(await _teacherApplicationService.GetTeacherById(teacherId));
    }
}