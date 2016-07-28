using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Executor.Models;

namespace Executor.IO.Interfaces
{
   public interface ICourse
   {
       string getName();

       Dictionary<string, Student> GetStudentByName();

       void EnrollStudent(Student student);
   }
}
