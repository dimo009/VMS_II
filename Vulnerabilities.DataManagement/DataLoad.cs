using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Vulnerabilites.Data.Context;
using Vulnerabilities.Data.Models;
using Vulnerabilities.DataManagement.Constants;

namespace Vulnerabilities.DataManagement
{

    public class DataLoad
    {
        private readonly VulnerabilityDBContext context;
        private readonly MpcDBContext mpcConfigContext;
        private readonly MPCMissingPatchDbContext mpcPatchContext;

        public DataLoad(VulnerabilityDBContext context, MpcDBContext mpcConfigContext, MPCMissingPatchDbContext mpcPatchContext)
        {
            this.context = context;
            this.mpcConfigContext = mpcConfigContext;
            this.mpcPatchContext = mpcPatchContext;
        }


        public void DataLoadingFromExcel()
        {
            int currentMonth;
            int currentYear = DateTime.Now.Year;


            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\dstoyanov5\OneDrive - DXC Production\source\repos\Vulnerabilities\Vulnerabilities.DataManagement\Resources");
            //int fileCount = directory.GetFiles().Length;
            //bool containsFileForUpload = directory.GetFiles().Any(f => f.Name == "ConfigFindingsSEP2018.xlsx");

            FileInfo fileConfigFindings = new FileInfo(PathConstants.excelFilePath);


            //getting the current month from the excel file - when the excel file was created. 

            currentMonth = fileConfigFindings.CreationTime.Month - 1;

            using (ExcelPackage package = new ExcelPackage(fileConfigFindings))
            {
                ExcelWorksheet rawData = package.Workbook.Worksheets[1];

                int rowCount = rawData.Dimension.Rows; //3430
                int colCount = rawData.Dimension.Columns; //35
                string targetValue = Convert.ToString(rawData.Cells[rowCount, 1].Value);
                if (Convert.ToString(rawData.Cells[rowCount, 1].Value) != "Uploaded")
                {
                    for (int row = 2; row <= rowCount; row++)
                    {
                        if ((Convert.ToString(rawData.Cells[row, 2].Value) == "ZZZZZ"))
                        {
                            continue;
                        }

                        string ip = Convert.ToString(rawData.Cells[row, 1].Value);
                        string systemName = Convert.ToString(rawData.Cells[row, 2].Value);
                        string systemStatus = Convert.ToString(rawData.Cells[row, 3].Value);
                        string systemType = Convert.ToString(rawData.Cells[row, 4].Value);
                        string osVersion = Convert.ToString(rawData.Cells[row, 5].Value);
                        string technicalOwner = Convert.ToString(rawData.Cells[row, 6].Value);
                        string downtimeContact = Convert.ToString(rawData.Cells[row, 7].Value);
                        string ipType = Convert.ToString(rawData.Cells[row, 8].Value);
                        string qid = Convert.ToString(rawData.Cells[row, 13].Value);
                        string title = Convert.ToString(rawData.Cells[row, 14].Value);
                        string severity = Convert.ToString(rawData.Cells[row, 16].Value);
                        string port = Convert.ToString(rawData.Cells[row, 17].Value);
                        DateTime lastDetected = DateTime.Parse(Convert.ToString(rawData.Cells[row, 20].Value));
                        string cve = Convert.ToString(rawData.Cells[row, 21].Value);
                        string solution = Convert.ToString(rawData.Cells[row, 23].Value);

                        if (!context.Vulnerabilities.Any(v => v.Name == title))
                        {
                            Vulnerability vulnerability = new Vulnerability
                            {
                                Name = title,
                                Severity = severity,
                                LastDetected = lastDetected,
                                CVE = cve,
                                Solution = solution,
                                QID = qid,
                                Notes = string.Empty,

                            };
                            Server server = new Server
                            {
                                Ip = ip,
                                SystemName = systemName,
                                SystemStatus = systemStatus,
                                SystemType = systemType,
                                OSversion = osVersion,
                                TechnicalOwner = technicalOwner,
                                DowntimeContact = downtimeContact,
                                Port = port,
                                LastDetected = lastDetected,
                                Notes = string.Empty

                            };

                            vulnerability.Servers = new List<ServerVulnerability>
                        {
                            new ServerVulnerability
                            {
                                Vulnerability=vulnerability,
                                Server = server
                            }
                        };
                            context.Vulnerabilities.Add(vulnerability);
                            context.SaveChanges();
                        }

                        else
                        {
                            Vulnerability vulnerability = context.Vulnerabilities.Where(v => v.Name == title).FirstOrDefault();
                            Server server = new Server
                            {
                                Ip = ip,
                                SystemName = systemName,
                                SystemStatus = systemStatus,
                                SystemType = systemType,
                                OSversion = osVersion,
                                TechnicalOwner = technicalOwner,
                                DowntimeContact = downtimeContact,
                                Port = port,
                                LastDetected = lastDetected,
                                Notes = string.Empty

                            };

                            //vulnerability.Servers.Add(new ServerVulnerability { Vulnerability = vulnerability, Server = server });

                            context.Vulnerabilities.FirstOrDefault(v => v.Name == title).Servers.Add(new ServerVulnerability { Vulnerability = vulnerability, Server = server });
                            context.SaveChanges();
                        }

                    }


                    rawData.Cells[rowCount + 1, 1].Value = "Uploaded";
                    package.Save();
                }


            }

            FileInfo fileMPCConfig = new FileInfo(PathConstants.MpcConfigExcel);
            using (ExcelPackage package = new ExcelPackage(fileMPCConfig))
            {
                ExcelWorksheet rawData = package.Workbook.Worksheets[1];

                int rowCount = rawData.Dimension.Rows; //3430
                int colCount = rawData.Dimension.Columns; //35
                string targetValue = Convert.ToString(rawData.Cells[rowCount, 1].Value);
                if (Convert.ToString(rawData.Cells[rowCount, 1].Value) != "Uploaded")
                {
                    for (int row = 2; row <= rowCount; row++)
                    {
                        if ((Convert.ToString(rawData.Cells[row, 2].Value) == "ZZZZZ") || (Convert.ToString(rawData.Cells[row, 2].Value) == @"#N/A"))
                        {
                            continue;
                        }

                        string ip = Convert.ToString(rawData.Cells[row, 1].Value);
                        string systemName = Convert.ToString(rawData.Cells[row, 2].Value);
                        string systemStatus = Convert.ToString(rawData.Cells[row, 3].Value);
                        string systemType = Convert.ToString(rawData.Cells[row, 4].Value);
                        string osVersion = Convert.ToString(rawData.Cells[row, 5].Value);
                        string technicalOwner = Convert.ToString(rawData.Cells[row, 6].Value);
                        string downtimeContact = Convert.ToString(rawData.Cells[row, 7].Value);
                        string ipType = Convert.ToString(rawData.Cells[row, 8].Value);
                        string qid = Convert.ToString(rawData.Cells[row, 15].Value);
                        string title = Convert.ToString(rawData.Cells[row, 16].Value);
                        string severity = Convert.ToString(rawData.Cells[row, 19].Value);
                        string port = Convert.ToString(rawData.Cells[row, 20].Value);
                        DateTime lastDetected = DateTime.Parse(Convert.ToString(rawData.Cells[row, 25].Value));
                        string cve = Convert.ToString(rawData.Cells[row, 28].Value);
                        string solution = Convert.ToString(rawData.Cells[row, 31].Value);

                        if (!mpcConfigContext.Vulnerabilities.Any(v => v.Name == title))
                        {
                            Vulnerability vulnerability = new Vulnerability
                            {
                                Name = title,
                                Severity = severity,
                                LastDetected = lastDetected,
                                CVE = cve,
                                Solution = solution,
                                QID = qid,
                                Notes = string.Empty,

                            };
                            Server server = new Server
                            {
                                Ip = ip,
                                SystemName = systemName,
                                SystemStatus = systemStatus,
                                SystemType = systemType,
                                OSversion = osVersion,
                                TechnicalOwner = technicalOwner,
                                DowntimeContact = downtimeContact,
                                LastDetected = lastDetected,
                                Port = port,
                                Notes = string.Empty

                            };

                            vulnerability.Servers = new List<ServerVulnerability>
                        {
                            new ServerVulnerability
                            {
                                Vulnerability=vulnerability,
                                Server = server
                            }
                        };
                            mpcConfigContext.Vulnerabilities.Add(vulnerability);
                            mpcConfigContext.SaveChanges();
                        }

                        else
                        {
                            Vulnerability vulnerability = mpcConfigContext.Vulnerabilities.Where(v => v.Name == title).FirstOrDefault();
                            Server server = new Server
                            {
                                Ip = ip,
                                SystemName = systemName,
                                SystemStatus = systemStatus,
                                SystemType = systemType,
                                OSversion = osVersion,
                                TechnicalOwner = technicalOwner,
                                DowntimeContact = downtimeContact,
                                LastDetected = lastDetected,
                                Port = port,
                                Notes = string.Empty

                            };

                            //vulnerability.Servers.Add(new ServerVulnerability { Vulnerability = vulnerability, Server = server });

                            mpcConfigContext.Vulnerabilities.FirstOrDefault(v => v.Name == title).Servers.Add(new ServerVulnerability { Vulnerability = vulnerability, Server = server });
                            mpcConfigContext.SaveChanges();
                        }

                    }
                    rawData.Cells[rowCount + 1, 1].Value = "Uploaded";
                    package.Save();
                }
            }



            FileInfo fileMPCPatch = new FileInfo(PathConstants.MpcPatchExcel);
            using (ExcelPackage package = new ExcelPackage(fileMPCPatch))
            {
                ExcelWorksheet rawData = package.Workbook.Worksheets[1];

                int rowCount = rawData.Dimension.Rows; //3430
                int colCount = rawData.Dimension.Columns; //35

                string targetValue = Convert.ToString(rawData.Cells[rowCount, 1].Value);
                if (Convert.ToString(rawData.Cells[rowCount, 1].Value) != "Uploaded")
                {
                    for (int row = 2; row <= rowCount; row++)
                    {
                        if ((Convert.ToString(rawData.Cells[row, 2].Value) == "ZZZZZ")|| (Convert.ToString(rawData.Cells[row, 2].Value) == @"#N/A"))
                        {
                            continue;
                        }

                        string ip = Convert.ToString(rawData.Cells[row, 1].Value);
                        string systemName = Convert.ToString(rawData.Cells[row, 2].Value);
                        string systemStatus = Convert.ToString(rawData.Cells[row, 3].Value);
                        string systemType = Convert.ToString(rawData.Cells[row, 4].Value);
                        string osVersion = Convert.ToString(rawData.Cells[row, 5].Value);
                        string technicalOwner = Convert.ToString(rawData.Cells[row, 6].Value);
                        string downtimeContact = Convert.ToString(rawData.Cells[row, 7].Value);
                        string ipType = Convert.ToString(rawData.Cells[row, 8].Value);
                        string qid = Convert.ToString(rawData.Cells[row, 15].Value);
                        string title = Convert.ToString(rawData.Cells[row, 16].Value);
                        string severity = Convert.ToString(rawData.Cells[row, 19].Value);
                        string port = Convert.ToString(rawData.Cells[row, 20].Value);
                        DateTime lastDetected = DateTime.Parse(Convert.ToString(rawData.Cells[row, 25].Value));
                        string cve = Convert.ToString(rawData.Cells[row, 28].Value);
                        string solution = Convert.ToString(rawData.Cells[row, 31].Value);

                        if (!mpcPatchContext.Vulnerabilities.Any(v => v.Name == title))
                        {
                            Vulnerability vulnerability = new Vulnerability
                            {
                                Name = title,
                                Severity = severity,
                                LastDetected = lastDetected,
                                CVE = cve,
                                Solution = solution,
                                QID = qid,
                                Notes = string.Empty,

                            };
                            Server server = new Server
                            {
                                Ip = ip,
                                SystemName = systemName,
                                SystemStatus = systemStatus,
                                SystemType = systemType,
                                OSversion = osVersion,
                                TechnicalOwner = technicalOwner,
                                DowntimeContact = downtimeContact,
                                LastDetected = lastDetected,
                                Port = port,
                                Notes = string.Empty

                            };

                            vulnerability.Servers = new List<ServerVulnerability>
                        {
                            new ServerVulnerability
                            {
                                Vulnerability=vulnerability,
                                Server = server
                            }
                        };
                            mpcPatchContext.Vulnerabilities.Add(vulnerability);
                            mpcPatchContext.SaveChanges();
                        }

                        else
                        {
                            Vulnerability vulnerability = mpcPatchContext.Vulnerabilities.Where(v => v.Name == title).FirstOrDefault();
                            Server server = new Server
                            {
                                Ip = ip,
                                SystemName = systemName,
                                SystemStatus = systemStatus,
                                SystemType = systemType,
                                OSversion = osVersion,
                                TechnicalOwner = technicalOwner,
                                DowntimeContact = downtimeContact,
                                LastDetected = lastDetected,
                                Port = port,
                                Notes = string.Empty

                            };

                            //vulnerability.Servers.Add(new ServerVulnerability { Vulnerability = vulnerability, Server = server });

                            mpcPatchContext.Vulnerabilities.FirstOrDefault(v => v.Name == title).Servers.Add(new ServerVulnerability { Vulnerability = vulnerability, Server = server });
                            mpcPatchContext.SaveChanges();
                        }

                    }
                    rawData.Cells[rowCount + 1, 1].Value = "Uploaded";
                    package.Save();
                }
            }
        }
    }
}


