using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iReport.Persistence
{
    public class ReportCard
    {
        /* Base */
        private string xmlFile = Properties.Settings.Default.xmlReportCard;

        private List<Model.ReportCard> reportCards;

        public ReportCard()
        {
            StreamReader stream = null;
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.ReportCard>));
            try
            {
                stream = new StreamReader(xmlFile);
                reportCards = (List<Model.ReportCard>)xml.Deserialize(stream);
            }
            catch
            {
                reportCards = new List<Model.ReportCard>();
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }

        private void SubmitChanges()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Model.ReportCard>));
            StreamWriter stream = new StreamWriter(xmlFile);
            xml.Serialize(stream, reportCards);
            stream.Close();
        }

        /* CRUD ReportCard */

        public bool Insert(Model.ReportCard s)
        {
            try
            {
                s.Quarter1 = 0;
                s.Quarter2 = 0;
                s.Quarter3 = 0;
                s.Quarter4 = 0;
                s.PartialAverage = (s.Quarter1 + s.Quarter2 + s.Quarter3 + s.Quarter4) / 4;
                s.Final = null;
                reportCards.Add(s);
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateQuarter(Model.ReportCard s, int quarter)
        {
            try
            {
                Model.ReportCard sNew = Get(s.Year, s.IdStudent, s.IdSubject);
                switch (quarter)
                {
                    case 1 :
                        sNew.Quarter1 = s.Quarter1;
                        break;
                    case 2:
                        sNew.Quarter2 = s.Quarter2;
                        break;
                    case 3:
                        sNew.Quarter3 = s.Quarter3;
                        break;
                    case 4:
                        sNew.Quarter4 = s.Quarter4;
                        break;
                    case 5:
                        sNew.Final = s.Final;
                        break;
                }
                sNew.PartialAverage = (sNew.Quarter1 + sNew.Quarter2 + sNew.Quarter3 + sNew.Quarter4) / 4;
                sNew.Average = sNew.Final.HasValue ? (sNew.Quarter1 + sNew.Quarter2 + sNew.Quarter3 + sNew.Quarter4 + sNew.Final.Value) / 5 : (sNew.Quarter1 + sNew.Quarter2 + sNew.Quarter3 + sNew.Quarter4) / 4;
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }        

        public bool Delete(Model.ReportCard s)
        {
            try
            {
                reportCards.Remove(Get(s.Year, s.IdStudent, s.IdSubject));
                SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Model.ReportCard> GetList(int idStudent=0, int idSubject=0, int year =0)
        {
            if (year>0 && idStudent>0 && idSubject>0)
            {
                return reportCards.Where(rc => rc.Year == year).Where(rc => rc.IdStudent == idStudent).Where(rc => rc.IdSubject == idSubject).ToList();
            }
            else if (idStudent > 0 && idSubject > 0)
            {
                return reportCards.Where(rc => rc.IdStudent == idStudent).Where(rc => rc.IdSubject == idSubject).ToList();
            }
            else if (idStudent > 0)
            {
                return reportCards.Where(rc => rc.IdStudent == idStudent).ToList();
            }
            return reportCards;
        }

        public Model.ReportCard Get(int year, int idStudent, int idSubject)
        {
            return reportCards.Where(rc=>rc.Year ==year).Where(rc=>rc.IdStudent == idStudent).SingleOrDefault(rc=>rc.IdSubject == idSubject);
        }
    }
}
