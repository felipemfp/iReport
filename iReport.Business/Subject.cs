using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReport.Business
{
    public class Subject
    {
        private Persistence.Subject PSubject;

        public Subject()
        {
            this.PSubject = new Persistence.Subject();
        }

        public string Insert(Model.Subject s)
        {
            if (String.IsNullOrWhiteSpace(s.Description))
            {
                return "The description field is required.";
            }
            return PSubject.Insert(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string Update(Model.Subject s)
        {
            if (String.IsNullOrWhiteSpace(s.Description))
            {
                return "The description field is required.";
            }
            return PSubject.Update(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string Delete(Model.Subject s)
        {
            if (s.Id == null)
            {
                return "The id field is required.";
            }
            else if (s.Id < 1)
            {
                return "The id field needs to be greater than zero.";
            }
            return PSubject.Delete(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public List<Model.Subject> GetList()
        {
            return PSubject.GetList();
        }

        public Model.Subject Get(int id)
        {
            return PSubject.Get(id);
        }
    }
}
