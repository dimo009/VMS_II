namespace Vulnerabilities.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Vulnerabilites.Data.Context;
    using Vulnerabilities.Data.Models;
    using Vulnerabilities.Services.Contracts;
    using Vulnerabilities.Services.Models.MPCconfigModels;
    using Vulnerabilities.Services.Models.MPCpatchModels;
    using Vulnerabilities.Services.Models.StandardEnvironment;

    public class ServerService : IServerService
    {
        private readonly VulnerabilityDBContext db;
        private readonly MpcDBContext mpcConfigDB;
        private readonly MPCMissingPatchDbContext mpcPatchDB;

        private readonly int currentYear = DateTime.Now.Year;
        private readonly int currentMonth = DateTime.Now.Day <= 26 ? DateTime.Now.AddMonths(-1).Month : DateTime.Now.Month;

        public ServerService(VulnerabilityDBContext db, MpcDBContext mpcConfigDB, MPCMissingPatchDbContext mpcPatchDB)
        {
            this.db = db;
            this.mpcConfigDB = mpcConfigDB;
            this.mpcPatchDB = mpcPatchDB;
        }

       // this.db.Servers.Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                    //.Where(s => s.LastDetected.Year == currentYear && s.LastDetected.Month == currentMonth).ToList();

        public IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerability(int? id)
        {
            //var query = from server in db.Servers
            //            where server.Vulnerabilities.Any(c => c.VulnerabilityId == id)
            //          select server.Vulnerabilities.FirstOrDefault(v=>v.VulnerabilityId==id);
            
            var result = this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s=>s.LastDetected.Year == currentYear && s.LastDetected.Month==currentMonth)
                .OrderBy(s => s.TechnicalOwner).ThenBy(s => s.DowntimeContact)
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
                    VulnerabilityID = id
                    
                }).ToList();

            return result;

        }

        public IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfig(int? id)
        {
            //var query = from server in mpcConfigDB.Servers
            //            where server.Vulnerabilities.Any(c => c.VulnerabilityId == id)
            //            select server;

            var result = this.mpcConfigDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == currentYear && s.LastDetected.Month == currentMonth)
                .OrderBy(s => s.TechnicalOwner).ThenBy(s => s.DowntimeContact)
                .Select(s => new VServersListingModelMpcConfig
                {
                    Id = s.Id,
                    Ip=s.Ip,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes
                }).ToList();

            return result;

        }

        public IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatch(int? id)
        {
           // var query = from server in mpcPatchDB.Servers
                       // where server.Vulnerabilities.Any(c => c.VulnerabilityId == id)
                        //select server;

            var result = this.mpcPatchDB.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id))
                .Where(s => s.LastDetected.Year == currentYear && s.LastDetected.Month == currentMonth)
                .OrderBy(s=>s.TechnicalOwner).ThenBy(s=>s.DowntimeContact)
                .Select(s => new VServersListingModelMpcPatch
                {
                    Id = s.Id,
                    Ip = s.Ip,
                    SystemName = s.SystemName,
                    SystemStatus = s.SystemStatus,
                    SystemType = s.SystemType,
                    OSversion = s.OSversion,
                    TechnicalOwner = s.TechnicalOwner,
                    DowntimeContact = s.DowntimeContact,
                    LastDetected = s.LastDetected,
                    Port = s.Port,
                    Notes = s.Notes
                }).ToList();

            return result;

        }

       

        public int TotalPages(int? id)
        {
            return this.db.Servers
                .Where(s => s.Vulnerabilities.Any(v => v.VulnerabilityId == id)).Count();
        }
    }
}
