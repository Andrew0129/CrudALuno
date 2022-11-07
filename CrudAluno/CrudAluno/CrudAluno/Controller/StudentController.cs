using CrudAluno.BussinesRules.Interface;
using CrudAluno.Model;
using CrudAluno.ServiceResult;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace CrudAluno.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentBussines _studentBussines;


        public StudentController(
            IStudentBussines studentBussines)
        {
            _studentBussines = studentBussines;
        }



        /// <summary>
        /// Create group
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            if (student == null)
                return BadRequest("No have body");

            var result = _studentBussines.CreateStudent(student);
            if (result.ResultType == ResultType.Ok)
                return Ok(result.Data);

            return BadRequest(result.Error);
        }

        /// <summary>
        /// Create group
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Student student)
        {
            if (student == null)
                return BadRequest("No have body");

            var result = _studentBussines.UpdateStudent(student);
            if (result.ResultType == ResultType.Ok)
                return Ok();

            return BadRequest(result.Error);
        }

        /// <summary>
        /// Create group
        /// </summary>
        /// <param name="ra"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(int ra)
        {
            if (ra == null)
                return BadRequest("No have body");

            var result = _studentBussines.DeleteStudent(ra);
            if (result.ResultType == ResultType.Ok)
                return Ok();

            return BadRequest(result.Error);
        }

        /// <summary>
        /// Create group
        /// </summary>
        /// <param name="ra"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllStudents()
        {

            var result = _studentBussines.GetAllStudents();
            if (result.ResultType == ResultType.Ok)
                return Ok(result.Data);

            return BadRequest(result.Error);
        }
    }
}
