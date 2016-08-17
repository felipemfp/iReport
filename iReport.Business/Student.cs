using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReport.Business
{
    public class Student
    {
        private Persistence.Student PStudent;

        public Student()
        {
            this.PStudent = new Persistence.Student();
        }

        public string Insert(Model.Student s)
        {
            if (String.IsNullOrWhiteSpace(s.Name))
            {
                return "The name field is required.";
            }
            return PStudent.Insert(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string Update(Model.Student s)
        {
            if (String.IsNullOrWhiteSpace(s.Name))
            {
                return "The name field is required.";
            }
            return PStudent.Update(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string Delete(Model.Student s)
        {
            if (s.Id == null)
            {
                return "The id field is required.";
            }
            else if (s.Id < 1)
            {
                return "The id field needs to be greater than zero.";
            }
            return PStudent.Delete(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public List<Model.Student> GetList(int idCourse = 0)
        {
            return PStudent.GetList(idCourse);
        }

        public Model.Student Get(int id)
        {
            return PStudent.Get(id);
        }
    }
}
