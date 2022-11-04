using CrudAluno.BussinesRules.Interface;
using CrudAluno.Context;
using CrudAluno.Model;
using CrudAluno.ServiceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAluno.BussinesRules
{
    public class StudentBussines : IStudentBussines
    {
        private StudentContext _studentContext;


        public StudentBussines(
            StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public Result<string> CreateStudent(Student student)
        {
            if (student == null)
                return new Result<string>().InvalidResult("student nulo");

            if (string.IsNullOrEmpty(student.Name))
                return new Result<string>().InvalidResult("student must have name");

            if (string.IsNullOrEmpty(student.Email))
                return new Result<string>().InvalidResult("student must have email");

            if (string.IsNullOrEmpty(student.CPF))
                return new Result<string>().InvalidResult("student must have cpf");

            if (student.Name.Length < 3)
                return new Result<string>().InvalidResult("The name must be 3 or more characters long");

            var create = new Student
            {
                Name = student.Name,
                CPF = student.CPF,
                Email = student.Email
            };

            _studentContext.Students.Add(create);
            _studentContext.SaveChanges();

            return new Result<string>().SuccessResult();
        }

        public Result<string> DeleteStudent(int ra)
        {
            var studentId = _studentContext.Students.FirstOrDefault(x => x.RA == ra);
            if (studentId != null)
            {
                _studentContext.Students.Remove(studentId);
            }

            return new Result<string>().SuccessResult();
        }

        public Result<string> UpdateStudent(Student student)
        {
            var studentId =  _studentContext.Students.FirstOrDefault(x => x.RA == student.RA);
            if (studentId != null)
            {
                _studentContext.Students.Update(student);
            }
            else
            {
                CreateStudent(student);
            }


            return new Result<string>().SuccessResult();
        }


        public Result<Student> GetAllStudents()
        {
            var student = _studentContext.Students.Find();
            if (student == null)
            {
                return new Result<Student>().InvalidResult("No have students!");
            }


            return new Result<Student>().SuccessResult(student);
        }
    }
}
