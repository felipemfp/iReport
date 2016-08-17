using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iReport.Persistence
{
    public class Subject
    {
        /* Base */
        private string xmlFile = Properties.Settings.Default.xmlSubject;

        private List<Model.Subject> subjects;

        public Subject()
        {
            StreamReader stream = null;
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.Subject>));
            try
            {
                stream = new StreamReader(xmlFile);
                subjects = (List<Model.Subject>)xml.Deserialize(stream);
            }
            catch
            {
                subjects = new List<Model.Subject>();
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }

        private void SubmitChanges()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.Subject>));
            StreamWriter stream = new StreamWriter(xmlFile);
            xml.Serialize(stream, subjects);
            stream.Close();
        }

        /* CRUD Subject */

        public bool Insert(Model.Subject s)
        {
            try
            {
                s.Id = subjects.Count > 0 ? subjects.Max(subject => subject.Id) + 1 : 1;
                subjects.Add(s);
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Model.Subject s)
        {
            try
            {
                Model.Subject sNew = Get(s.Id);
                sNew.Description = s.Description;
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }        

        public bool Delete(Model.Subject s)
        {
            try
            {
                subjects.Remove(Get(s.Id));
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Model.Subject> GetList()
        {
            return subjects;
        }

        public Model.Subject Get(int id)
        {
            return subjects.Single(subject=>subject.Id == id);
        }
    }
}
