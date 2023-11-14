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
        public Report GetReportByReportID(int id) => ReportDAO.Instance.GetReportByReportID(id);
        public void ReportPost(Report report) => ReportDAO.Instance.ReportPost(report);
        public void AddReport(Report report) => ReportDAO.Instance.AddReport(report);
        public void UpdateReport(Report report) => ReportDAO.Instance.UpdateReport(report);
        public List<Report> GetReportsByUserID(int userID) => ReportDAO.Instance.GetReportsByUserID(userID);
    }
}
