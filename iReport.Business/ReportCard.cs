using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReport.Business
{
    public class ReportCard
    {
        private Persistence.ReportCard PReportCard;

        public ReportCard()
        {
            this.PReportCard = new Persistence.ReportCard();
        }

        public string Insert(Model.ReportCard s)
        {
            if (s.Year == null && s.IdSubject == null && s.IdStudent == null)
            {
                return "The Report Card identifiers fields are required.";
            }
            return PReportCard.Insert(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string UpdateQuarter(Model.ReportCard s, int quarter)
        {
            if (s.Year == null && s.IdSubject == null && s.IdStudent == null)
            {
                return "The Report Card identifiers fields are required.";
            }
            else if (String.IsNullOrWhiteSpace(s.Quarter1.ToString()))
            {
                return "The quarter field is required.";
            }
            return PReportCard.UpdateQuarter(s, quarter) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public string Delete(Model.ReportCard s)
        {
            if (s.Year == null && s.IdSubject == null && s.IdStudent == null)
            {
                return "The Report Card identifiers fields are required.";
            }
            return PReportCard.Delete(s) ? "Operation was successful." : "An unexpected error occurred.";
        }

        public List<Model.ReportCard> GetList(int idStudent = 0, int idSubject = 0, int year = 0)
        {
            if (year > 0 && idStudent > 0 && idSubject > 0)
            {
                return PReportCard.GetList(idStudent, idSubject, year);
            }
            else if (idStudent > 0 && idSubject > 0)
            {
                return PReportCard.GetList(idStudent, idSubject);
            }
            else if (idStudent > 0)
            {
                return PReportCard.GetList(idStudent);
            }
            return PReportCard.GetList();
        }

        public Model.ReportCard Get(int year, int idStudent, int idSubject)
        {
            return PReportCard.Get(year, idStudent, idSubject);
        }
    }
}
