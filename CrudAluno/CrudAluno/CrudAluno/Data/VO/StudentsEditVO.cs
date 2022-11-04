using CrudAluno.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAluno.Data.VO
{
    public class StudentsEditVO
    {
        public int RA { get; set; }
        public string Name { get; set;}
        public string Email { get; set; }

        public StudentsEditVO(Student students)
        {
            RA = students.RA;
            Name = students.Name;
            Email = students.Email;
        }
    }
}
