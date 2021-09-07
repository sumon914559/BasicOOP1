using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    public class University
    {
        private string name;
        private List<Department> departments;

        public University(string name)
        {
            this.name = name;
            this.departments = new List<Department>();
        }

        public bool AddDepartment(Department department)
        {
            ValidateDepartment(department);

            this.departments.Add(department);

            return true;
        }

        private void ValidateDepartment(Department department)
        {
            var codeExists = this.departments.FirstOrDefault(x => x.getCode() == department.getCode());
            var nameExists = this.departments.FirstOrDefault(x => x.getName() == department.getName());

            if (nameExists != null || codeExists != null)
            {
                var message = "";
                if (codeExists != null)
                {
                    message += $"{department.getCode()} code already exists\n";
                }

                if (nameExists != null)
                {
                    message += $"{department.getName()} name already exists\n";
                }

                throw new Exception(message);
            }

            if (this.departments.Count >= 2)
            {
                throw new Exception("new department insert is not possible");
            }
        }
    }
}