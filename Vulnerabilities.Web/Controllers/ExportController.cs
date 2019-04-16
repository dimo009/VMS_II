using GemBox.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Vulnerabilities.Services.Contracts;
using OfficeOpenXml;
using ExcelWorksheet = OfficeOpenXml.ExcelWorksheet;
using Vulnerabilities.Services.Models.StandardEnvironment;
using Vulnerabilites.Data.Context;
using OfficeOpenXml.Style;
using System.Drawing;


namespace Vulnerabilities.Web.Controllers
{
    public class ExportController:Controller
    {
        private readonly IVulnerabilityService vulnerabilities;
        private readonly IServerService servers;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly VulnerabilityDBContext db;
        private readonly MpcDBContext mpcConfigDB;
        private readonly MPCMissingPatchDbContext mpcPatchDB;
        private readonly int currentMonth = DateTime.Now.Day <= 26 ? DateTime.Now.AddMonths(-1).Month : DateTime.Now.Month;
        private readonly int currentYear = DateTime.Now.Year;


        public ExportController(IVulnerabilityService vulnerabilities, IServerService servers, IHostingEnvironment hostingEnvironment, 
            VulnerabilityDBContext db, MpcDBContext mpcConfigDB, MPCMissingPatchDbContext mpcPatchDB)
        {
            this.vulnerabilities = vulnerabilities;
            this.servers = servers;
            _hostingEnvironment = hostingEnvironment;
            this.db = db;
            this.mpcConfigDB = mpcConfigDB;
            this.mpcPatchDB = mpcPatchDB;
        }

        [HttpGet]
        [Route(nameof(ExportData) + "/id")]
        public string ExportData(int?id)
        {
            string rootFolder = _hostingEnvironment.WebRootPath;
            
            string fileName = @"ExportServers.xlsx";

            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                //To be modified the way currentMonth is calculated
                var serverList = this.db.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                    .Where(s => s.LastDetected.Year == currentYear && s.LastDetected.Month == currentMonth).ToList();

                var vulnTitle = this.db.Vulnerabilities.FirstOrDefault(v => v.Id == id).Name;



                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("AffectedServers");
                int totalRows = serverList.Count();

                var titleRange = worksheet.Cells[1, 1, 1, 11];
                var contentRange = worksheet.Cells[2, 1, totalRows, 11];
                titleRange.AutoFilter = true;
                titleRange.AutoFitColumns();
                worksheet.DefaultColWidth = 20;
                titleRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                titleRange.Style.Fill.BackgroundColor.SetColor(Color.Black);
                titleRange.Style.Font.Color.SetColor(Color.White);

               
                worksheet.Cells[1, 1].Value = "IP";
                worksheet.Cells[1, 2].Value = "System name";
                worksheet.Cells[1, 3].Value = "System status";
                worksheet.Cells[1, 4].Value = "System type";
                worksheet.Cells[1, 5].Value = "OS Version";
                worksheet.Cells[1, 6].Value = "Technical owner";
                worksheet.Cells[1, 7].Value = "Downtime contact";
                worksheet.Cells[1, 8].Value = "Last detected date";
                worksheet.Cells[1, 9].Value = "Port";
                worksheet.Cells[1, 10].Value = "Notes";
                worksheet.Cells[1, 11].Value = "Vulnerability title";

                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = serverList[i].Ip;
                    worksheet.Cells[row, 2].Value = serverList[i].SystemName;
                    worksheet.Cells[row, 3].Value = serverList[i].SystemStatus;
                    worksheet.Cells[row, 4].Value = serverList[i].SystemType;
                    worksheet.Cells[row, 5].Value = serverList[i].OSversion;
                    worksheet.Cells[row, 6].Value = serverList[i].TechnicalOwner;
                    worksheet.Cells[row, 7].Value = serverList[i].DowntimeContact;
                    //worksheet.Cells[row, 8].Value = String.Format("{0:MM/dd/yyyy HH:mm:ss}",serverList[i].LastDetected);
                    worksheet.Cells[row, 8].Value = serverList[i].LastDetected.ToShortDateString();
                    worksheet.Cells[row, 9].Value = serverList[i].Port;
                    worksheet.Cells[row, 10].Value = serverList[i].Notes;
                    worksheet.Cells[row, 11].Value = vulnTitle;

                    i++;
                }

                package.Save();

            }

            return " Server list has been exported successfully";
        }
    }
}
