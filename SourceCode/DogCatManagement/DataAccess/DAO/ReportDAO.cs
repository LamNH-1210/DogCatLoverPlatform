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
    }
}
