using CrudAluno.Model;
using CrudAluno.ServiceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAluno.BussinesRules.Interface
{
    public interface IStudentBussines
    {
        Result<string> CreateStudent(Student student);
        Result<string> UpdateStudent(Student student);
        Result<string> DeleteStudent(int ra);
        Result<Student> GetAllStudents();
    }
}
