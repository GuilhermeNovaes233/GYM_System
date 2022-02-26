using GYM_System.Application.Interfaces;
using GYM_System.Application.ViewModels;
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
            => Ok(await _teacherApplicationService.GetTeacherByIdAsync(teacherId));

        /// <summary>
        /// Get Teacher
        /// </summary>
        /// <param name="teacherId"></param>
        /// <returns>Return to Teacher</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
            => Ok(await _teacherApplicationService.GetAllTeachersAsync());

        /// <summary>
        /// Create a Teacher
        /// </summary>
        /// <returns>Return a Teacher</returns>
        [HttpPost]
        public async Task<IActionResult> CreateTeacher([FromBody] TeacherViewModel model)
        {
            await _teacherApplicationService.CreateTeacherAsync(model);

            return Ok();
        }

        /// <summary>
        /// Update a Teacher
        /// </summary>
        /// <returns>Return a Teacher</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateTeacher([FromBody] TeacherViewModel model)
        {
            await _teacherApplicationService.UpdateTeacherAsync(model);

            return Ok();
        }

        /// <summary>
        /// Delete a Teacher
        /// </summary>
        /// <returns>Return a Teacher</returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteTeacher([FromBody] string teacherId)
        {
            await _teacherApplicationService.DeleteTeacherAsync(teacherId);

            return Ok();
        }
    }
}