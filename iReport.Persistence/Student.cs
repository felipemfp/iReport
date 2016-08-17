using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iReport.Persistence
{
    public class Student
    {
        /* Base */
        private string xmlFile = Properties.Settings.Default.xmlStudent;

        private List<Model.Student> students;

        public Student()
        {
            StreamReader stream = null;
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.Student>));
            try
            {
                stream = new StreamReader(xmlFile);
                students = (List<Model.Student>)xml.Deserialize(stream);
            }
            catch
            {
                students = new List<Model.Student>();
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }

        private void SubmitChanges()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.Student>));
            StreamWriter stream = new StreamWriter(xmlFile);
            xml.Serialize(stream, students);
            stream.Close();
        }

        /* CRUD Student */

        public bool Insert(Model.Student s)
        {
            try
            {
                s.Id = students.Count > 0 ? students.Max(student => student.Id) + 1 : 1;
                students.Add(s);
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Model.Student s)
        {
            try
            {
                Model.Student sNew = Get(s.Id);
                sNew.Name = s.Name;
                sNew.Email = s.Email;
                sNew.Phone = s.Phone;
                sNew.IdCourse = s.IdCourse;
                sNew.Birth = s.Birth;
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }        

        public bool Delete(Model.Student s)
        {
            try
            {
                students.Remove(Get(s.Id));
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Model.Student> GetList(int idCourse = 0)
        {
            if (idCourse>0)
            {
                return students.Where(s => s.IdCourse == idCourse).ToList();
            }
            return students;
        }

        public Model.Student Get(int id)
        {
            return students.Single(student=>student.Id == id);
        }
    }
}
