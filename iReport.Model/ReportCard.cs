using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReport.Model
{
    public class ReportCard
    {
        public int Year { get; set; }
        public int IdStudent { get; set; }
        public int IdSubject { get; set; }
        public int Quarter1 { get; set; }
        public int Quarter2 { get; set; }
        public int Quarter3 { get; set; }
        public int Quarter4 { get; set; }
        public int PartialAverage { get; set; }
        public Nullable<int> Final { get; set; }
        public int Average { get; set; }
    }
}
