using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReportRepository
    {
        List<Report> GetAllReportList();
        Report GetReportByReportID(int id);
        void ReportPost(Report report);
        void AddReport(Report report);
        void UpdateReport(Report report);
        List<Report> GetReportsByUserID(int userID);
    }
}
