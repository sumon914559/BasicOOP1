using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
   public class Department
   {
       private string name;
       private string code;
       private List<Student> students;


       public Department(string name, string code)
       {
           this.name = name;
           this.code = code;
           this.students = new List<Student>();
       }

       public string getName()
       {
           return this.name;
       }

       public string getCode()
       {
           return this.code;
       }
    }
}
