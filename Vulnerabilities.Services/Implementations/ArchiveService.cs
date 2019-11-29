using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vulnerabilites.Data.Context;
using Vulnerabilities.Services.Contracts;
using Vulnerabilities.Services.Models.MPCconfigModels;
using Vulnerabilities.Services.Models.MPCpatchModels;
using Vulnerabilities.Services.Models.StandardEnvironment;

namespace Vulnerabilities.Services.Implementations
{
    public class ArchiveService : IArchiveService
    {
        private readonly VulnerabilityDBContext db;
        private readonly MpcDBContext mpcConfigDB;
        private readonly MPCMissingPatchDbContext mpcPatchDB;

        public ArchiveService(VulnerabilityDBContext db, MpcDBContext mpcConfigDB, MPCMissingPatchDbContext mpcPatchDB)
        {
            this.db = db;
            this.mpcConfigDB = mpcConfigDB;
            this.mpcPatchDB = mpcPatchDB;
        }

        public IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityOCT2019(int? id)
        {
            string severity = this.db.Vulnerabilities.Find(id).Severity;

            var result = this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 10)
                .Select(s => new VServersListingModel
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilitySEP2019(int? id)
        {
            string severity = this.db.Vulnerabilities.Find(id).Severity;

            var result = this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 9)
                .Select(s => new VServersListingModel
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityAUG2019(int? id)
        {
            string severity = this.db.Vulnerabilities.Find(id).Severity;

            var result = this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 8)
                .Select(s => new VServersListingModel
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityJULY2019(int? id)
        {
            string severity = this.db.Vulnerabilities.Find(id).Severity;

            var result = this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 7)
                .Select(s => new VServersListingModel
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityJUNE2019(int? id)
        {
            string severity = this.db.Vulnerabilities.Find(id).Severity;

            var result = this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 6)
                .Select(s => new VServersListingModel
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityMAY2019(int? id)
        {
            string severity = this.db.Vulnerabilities.Find(id).Severity;

            var result = this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 5)
                .Select(s => new VServersListingModel
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }





        public IEnumerable<VulnerabilityListingModel> AllVulnerabilities(int month, int currentYear)
        {
            var result = this.db.Vulnerabilities
                .OrderByDescending(v => v.LastDetected.Year)
                .ThenBy(v => v.LastDetected.Month)
                .Where(v => v.Servers.Any(s => s.Server.LastDetected.Year == currentYear &&
                  s.Server.LastDetected.Month == month))
                .Select(v => new VulnerabilityListingModel
                {
                    Id = v.Id,
                    Name = v.Name,
                    Severity = v.Severity,
                    CVE = v.CVE,
                    Solution = v.Solution,
                    QID = v.QID,
                    Notes = v.Notes,
                    AffectedServersCount = v.Servers.Where(s => s.Server.LastDetected.Year == currentYear && s.Server.LastDetected.Month == month).Count()

                }).ToList();

            return result;
        }

        public IEnumerable<VulnerabilityListingModelMpcConfig> AllVulnerabilitiesMpcConfig(int month, int currentYear)
        {
            var result = this.mpcConfigDB.Vulnerabilities.OrderByDescending(v => v.LastDetected.Year).ThenBy(v => v.LastDetected.Month)
                .Where(v => v.Servers.Any(s => s.Server.LastDetected.Year == currentYear && s.Server.LastDetected.Month == month))
                .Select(v => new VulnerabilityListingModelMpcConfig
                {
                    Id = v.Id,
                    Name = v.Name,
                    Severity = v.Severity,
                    CVE = v.CVE,
                    Solution = v.Solution,
                    QID = v.QID,
                    Notes = v.Notes,
                    AffectedServersCount = v.Servers.Where(s => s.Server.LastDetected.Year == currentYear && s.Server.LastDetected.Month == month).Count()
                }).ToList();

            return result;
        }

        public IEnumerable<VulnerabilityListingModelMpcPatch> AllVulnerabilitiesMpcPatch(int month, int currentYear)
        {
            var result = this.mpcPatchDB.Vulnerabilities.OrderByDescending(v => v.LastDetected.Year).ThenBy(v => v.LastDetected.Month)
                .Where(v => v.Servers.Any(s => s.Server.LastDetected.Year == currentYear && s.Server.LastDetected.Month == month))
                .Select(v => new VulnerabilityListingModelMpcPatch
                {
                    Id = v.Id,
                    Name = v.Name,
                    Severity = v.Severity,
                    CVE = v.CVE,
                    Solution = v.Solution,
                    QID = v.QID,
                    Notes = v.Notes,
                    AffectedServersCount = v.Servers.Where(s => s.Server.LastDetected.Year == currentYear && s.Server.LastDetected.Month == month).Count()
                }).ToList();

            return result;
        }



        public IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigOCT2019(int? id)
        {
            string severity = this.mpcConfigDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcConfigDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 10)
                .Select(s => new VServersListingModelMpcConfig
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigSEP2019(int? id)
        {
            string severity = this.mpcConfigDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcConfigDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 9)
                .Select(s => new VServersListingModelMpcConfig
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigAUG2019(int? id)
        {
            string severity = this.mpcConfigDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcConfigDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 8)
                .Select(s => new VServersListingModelMpcConfig
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigJULY2019(int? id)
        {
            string severity = this.mpcConfigDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcConfigDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 7)
                .Select(s => new VServersListingModelMpcConfig
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigJUNE2019(int? id)
        {
            string severity = this.mpcConfigDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcConfigDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 6)
                .Select(s => new VServersListingModelMpcConfig
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigMAY2019(int? id)
        {
            string severity = this.mpcConfigDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcConfigDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 5)
                .Select(s => new VServersListingModelMpcConfig
                {
                    Id = s.Id,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes,
                    VulnerabilityID = id,
                    Severity = severity
                }).ToList();

            return result;
        }




        public IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchOCT2019(int? id)
        {
            string severity = this.mpcPatchDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcPatchDB.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 10)
                 .Select(s => new VServersListingModelMpcPatch
                 {
                     Id = s.Id,
                     SystemName = s.SystemName,
                     SystemStatus = s.SystemStatus,
                     SystemType = s.SystemType,
                     OSversion = s.OSversion,
                     TechnicalOwner = s.TechnicalOwner,
                     DowntimeContact = s.DowntimeContact,
                     LastDetected = s.LastDetected,
                     Port = s.Port,
                     Notes = s.Notes,
                     VulnerabilityID = id,
                     Severity = severity
                 }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchSEP2019(int? id)
        {
            string severity = this.mpcPatchDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcPatchDB.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 9)
                 .Select(s => new VServersListingModelMpcPatch
                 {
                     Id = s.Id,
                     SystemName = s.SystemName,
                     SystemStatus = s.SystemStatus,
                     SystemType = s.SystemType,
                     OSversion = s.OSversion,
                     TechnicalOwner = s.TechnicalOwner,
                     DowntimeContact = s.DowntimeContact,
                     LastDetected = s.LastDetected,
                     Port = s.Port,
                     Notes = s.Notes,
                     VulnerabilityID = id,
                     Severity = severity
                 }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchAUG2019(int? id)
        {
            string severity = this.mpcPatchDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcPatchDB.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 8)
                 .Select(s => new VServersListingModelMpcPatch
                 {
                     Id = s.Id,
                     SystemName = s.SystemName,
                     SystemStatus = s.SystemStatus,
                     SystemType = s.SystemType,
                     OSversion = s.OSversion,
                     TechnicalOwner = s.TechnicalOwner,
                     DowntimeContact = s.DowntimeContact,
                     LastDetected = s.LastDetected,
                     Port = s.Port,
                     Notes = s.Notes,
                     VulnerabilityID = id,
                     Severity = severity
                 }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchJULY2019(int? id)
        {
            string severity = this.mpcPatchDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcPatchDB.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 7)
                 .Select(s => new VServersListingModelMpcPatch
                 {
                     Id = s.Id,
                     SystemName = s.SystemName,
                     SystemStatus = s.SystemStatus,
                     SystemType = s.SystemType,
                     OSversion = s.OSversion,
                     TechnicalOwner = s.TechnicalOwner,
                     DowntimeContact = s.DowntimeContact,
                     LastDetected = s.LastDetected,
                     Port = s.Port,
                     Notes = s.Notes,
                     VulnerabilityID = id,
                     Severity = severity
                 }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchJUNE2019(int? id)
        {
            string severity = this.mpcPatchDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcPatchDB.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 6)
                 .Select(s => new VServersListingModelMpcPatch
                 {
                     Id = s.Id,
                     SystemName = s.SystemName,
                     SystemStatus = s.SystemStatus,
                     SystemType = s.SystemType,
                     OSversion = s.OSversion,
                     TechnicalOwner = s.TechnicalOwner,
                     DowntimeContact = s.DowntimeContact,
                     LastDetected = s.LastDetected,
                     Port = s.Port,
                     Notes = s.Notes,
                     VulnerabilityID = id,
                     Severity = severity
                 }).ToList();

            return result;
        }

        public IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchMAY2019(int? id)
        {
            string severity = this.mpcPatchDB.Vulnerabilities.Find(id).Severity;

            var result = this.mpcPatchDB.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == 2019 && s.LastDetected.Month == 5)
                 .Select(s => new VServersListingModelMpcPatch
                 {
                     Id = s.Id,
                     SystemName = s.SystemName,
                     SystemStatus = s.SystemStatus,
                     SystemType = s.SystemType,
                     OSversion = s.OSversion,
                     TechnicalOwner = s.TechnicalOwner,
                     DowntimeContact = s.DowntimeContact,
                     LastDetected = s.LastDetected,
                     Port = s.Port,
                     Notes = s.Notes,
                     VulnerabilityID = id,
                     Severity = severity
                 }).ToList();

            return result;
        }





    }
}
