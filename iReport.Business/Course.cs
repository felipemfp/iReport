using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReport.Business
{
    public class Course
    {
        private Persistence.Course PCourse;

        public Course()
        {
            this.PCourse = new Persistence.Course();
        }

        public string Insert(Model.Course c)
        {
            if (String.IsNullOrWhiteSpace(c.Description))
            {
                return "The description field is required.";
            }
            return PCourse.Insert(c) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string Update(Model.Course c)
        {
            if (String.IsNullOrWhiteSpace(c.Description))
            {
                return "The description field is required.";
            }
            return PCourse.Update(c) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string Delete(Model.Course c)
        {
            if (c.Id == null)
            {
                return "The id field is required.";
            }
            else if (c.Id < 1)
            {
                return "The id field needs to be greater than zero.";
            }
            return PCourse.Delete(c) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public List<Model.Course> GetList()
        {
            return PCourse.GetList();
        }

        public Model.Course Get(int id)
        {
            return PCourse.Get(id);
        }
    }
}
