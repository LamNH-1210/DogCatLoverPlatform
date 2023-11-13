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

        public Report GetReportByPostID(int postId)
        {

            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Reports.FirstOrDefault(m => m.PostId == postId);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateReport(Report report)
        {
            var dbContent = new DogCatLoverPlatformDBContext();
            Report existingReport = GetReportByPostID(report.ReportId);

            dbContent.Entry(existingReport).State = EntityState.Modified;
            dbContent.SaveChanges();
        }


        public void AddReport(Report report)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                Report existingReport = GetReportByPostID((int)report.PostId);

                if (existingReport == null)
                {
                    // If the report doesn't exist, add it to the database
                    ReportPost(report);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
