using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAluno.Model
{
    public class Aluno
    {
        [Key]
        public int RA { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
