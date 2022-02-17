using GYM_System.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// Get Teacher
        /// </summary>
        /// <param name="teacherId"></param>
        /// <returns>Return to Teacher</returns>
        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById([FromQuery] string teacherId)
            => Ok(await _teacherApplicationService.GetTeacherById(teacherId));
    }
}