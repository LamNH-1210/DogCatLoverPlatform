using DataAccess.DAO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReportRepository : IReportRepository
    {
        public List<Report> GetAllReportList() => ReportDAO.Instance.GetAllReportList();
        public Report GetReportByPostID(int id) => ReportDAO.Instance.GetReportByPostID(id);
        public void ReportPost(Report report) => ReportDAO.Instance.ReportPost(report);
        public void AddReport(Report report) => ReportDAO.Instance.AddReport(report);

    }
}
