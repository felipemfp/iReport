using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iReport.Persistence
{
    public class Course
    {
        /* Base */
        private string xmlFile = Properties.Settings.Default.xmlCourse;

        private List<Model.Course> courses;

        public Course()
        {
            StreamReader stream = null;
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.Course>));
            try
            {
                stream = new StreamReader(xmlFile);
                courses = (List<Model.Course>)xml.Deserialize(stream);
            }
            catch
            {
                courses = new List<Model.Course>();
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }

        private void SubmitChanges()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.Course>));
            StreamWriter stream = new StreamWriter(xmlFile);
            xml.Serialize(stream, courses);
            stream.Close();
        }

        /* CRUD Course */

        public bool Insert(Model.Course c)
        {
            try
            {
                c.Id = courses.Count > 0 ? courses.Max(course => course.Id) + 1 : 1;
                courses.Add(c);
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Model.Course c)
        {
            try
            {
                Model.Course cNew = Get(c.Id);
                cNew.Description = c.Description;
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }        

        public bool Delete(Model.Course c)
        {
            try
            {
                courses.Remove(Get(c.Id));
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Model.Course> GetList()
        {
            return courses;
        }

        public Model.Course Get(int id)
        {
            return courses.Single(course=>course.Id == id);
        }
    }
}
