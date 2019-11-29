using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vulnerabilites.Data.Context;
using Vulnerabilities.Services.Contracts;
using Vulnerabilities.Web.Models.Servers.StandardEnvironmentServers;
using Vulnerabilities.Web.Models.Vulnerabilities.StandardEnvironmentVulnerabilities;

namespace Vulnerabilities.Web.Controllers
{
    [Route(nameof(archives))]
    public class ArchiveController: Controller
    {
        private readonly IArchiveService archives;
        private readonly VulnerabilityDBContext db;
        private readonly MpcDBContext mpcConfigDB;
        private readonly MPCMissingPatchDbContext mpcPatchDB;


        public ArchiveController(IArchiveService archives, VulnerabilityDBContext db, MpcDBContext mpcConfigDB, MPCMissingPatchDbContext mpcPatchDB)
        {
            this.archives = archives;
            this.db = db;
            this.mpcConfigDB = mpcConfigDB;
            this.mpcPatchDB = mpcPatchDB;
        }

        [HttpGet]
        [Route(nameof(ArchivePage))]
        public IActionResult ArchivePage()
        {
            return View(nameof(ArchivePage));
        }

        [HttpGet]
        [Route(nameof(StandardEnvironmentArchives))]
        public IActionResult StandardEnvironmentArchives()
        {
            return View(nameof(StandardEnvironmentArchives));
        }


        //October START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourOctober2019))]
        public IActionResult SeverityFourOctober2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(10, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveOctober2019))]
        public IActionResult SeverityFiveOctober2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(10, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersOCT2019))]
        public IActionResult ImpactedServersOCT2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityOCT2019(id)

            });
        }


        //October END SECTION




        //September START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourSeptember2019))]
        public IActionResult SeverityFourSeptember2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(9, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveSeptember2019))]
        public IActionResult SeverityFiveSeptember2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(9, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersSEP2019))]
        public IActionResult ImpactedServersSEP2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilitySEP2019(id)

            });
        }


        //September END SECTION

        //AUGUST START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourAugust2019))]
        public IActionResult SeverityFourAugust2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(8, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveAugust2019))]
        public IActionResult SeverityFiveAugust2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(8, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersAUG2019))]
        public IActionResult ImpactedServersAUG2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityAUG2019(id)

            });
        }


        // AUGUST END SECTION

        //JULY START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourJuly2019))]
        public IActionResult SeverityFourJuly2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(7, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveJuly2019))]
        public IActionResult SeverityFiveJuly2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(7, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersJULY2019))]
        public IActionResult ImpactedServersJULY2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityJULY2019(id)

            });
        }


        // JULY END SECTION



        //JUNE START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourJune2019))]
        public IActionResult SeverityFourJune2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(6, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveJune2019))]
        public IActionResult SeverityFiveJune2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(6, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersJUNE2019))]
        public IActionResult ImpactedServersJUNE2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityJUNE2019(id)

            });
        }

        //JUNE END SECTION

        
        //MAY END SECTION

        [HttpGet]
        [Route(nameof(SeverityFourMay2019))]
        public IActionResult SeverityFourMay2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(5, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveMay2019))]
        public IActionResult SeverityFiveMay2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(5, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersMAY2019))]
        public IActionResult ImpactedServersMAY2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMAY2019(id)

            });
        }

        //MAY END SECTION



       

       
       

        
    }
}
