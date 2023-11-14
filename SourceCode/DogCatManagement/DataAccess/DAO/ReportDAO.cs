using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ReportDAO
    {
        private static ReportDAO instance;

        // Singlaton ReportDAO
        public static ReportDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReportDAO();
                }
                return instance;
            }
        }

        // GetAll Report
        public List<Report> GetAllReportList()
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Reports.Include( u => u.User).Include(u => u.Post).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ReportPost(Report report)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                dbContext.Add(report);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Report GetReportByReportID(int reportID)
        {

            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Reports.FirstOrDefault(m => m.ReportId == reportID);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateReport(Report report)
        {

                var dbContent = new DogCatLoverPlatformDBContext();
                Report existingReport = GetReportByReportID(report.ReportId);

                if (existingReport != null)
                {
                    // Update properties of existingReport with values from report parameter
                    existingReport.ReportId = report.ReportId;
                    // Update other properties as needed

                    dbContent.Entry(existingReport).State = EntityState.Modified;
                    dbContent.SaveChanges();
                }
            
        }


        public void AddReport(Report report)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                dbContext.Add(report);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Report> GetReportsByUserID(int userID)
        {

            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Reports.Where(p => p.UserId == userID).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
