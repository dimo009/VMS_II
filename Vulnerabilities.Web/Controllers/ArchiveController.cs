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


        //February START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourFebruary2019))]
        public IActionResult SeverityFourFebruary2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(2, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveFebruary2019))]
        public IActionResult SeverityFiveFebruary2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(2, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersFEB2019))]
        public IActionResult ImpactedServersFEB2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityFEB2019(id)

            });
        }


        //February END SECTION




        //JANUARY START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourJanuary2019))]
        public IActionResult SeverityFourJanuary2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(1, 2019).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveJanuary2019))]
        public IActionResult SeverityFiveJanuary2019()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(1, 2019).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersJAN2019))]
        public IActionResult ImpactedServersJAN2019(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityJAN2019(id)

            });
        }


        //JANUARY END SECTION

        //DECEMBER START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourDecember2018))]
        public IActionResult SeverityFourDecember2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(12, 2018).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveDecember2018))]
        public IActionResult SeverityFiveDecember2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(12, 2018).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersDEC2018))]
        public IActionResult ImpactedServersDEC2018(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityDEC2018(id)

            });
        }


        // DECEMBER END SECTION

        //NOVEMBER START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourNovember2018))]
        public IActionResult SeverityFourNovember2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(11, 2018).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveNovember2018))]
        public IActionResult SeverityFiveNovember2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(11, 2018).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersNOV2018))]
        public IActionResult ImpactedServersNOV2018(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityNOV2018(id)

            });
        }


        // NOVEMBER END SECTION



        //OCTOBER START SECTION

        [HttpGet]
        [Route(nameof(SeverityFourOctober2018))]
        public IActionResult SeverityFourOctober2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(10, 2018).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveOctober2018))]
        public IActionResult SeverityFiveOctober2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(10, 2018).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersOCT2018))]
        public IActionResult ImpactedServersOCT2018(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityOCT2018(id)

            });
        }

        //OCTOBER END SECTION

        
        //SEPTEMBER END SECTION

        [HttpGet]
        [Route(nameof(SeverityFourSeptember2018))]
        public IActionResult SeverityFourSeptember2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(9, 2018).Where(v => v.Severity == "4")
            });

        }

        [HttpGet]
        [Route(nameof(SeverityFiveSeptember2018))]
        public IActionResult SeverityFiveSeptember2018()
        {
            return View(new VulnerabilitiesListingViewModel
            {
                AllVulnerabilities = this.archives.AllVulnerabilities(9, 2018).Where(v => v.Severity == "5")
            });

        }

        [HttpGet]
        [Route(nameof(ImpactedServersSEP2018))]
        public IActionResult ImpactedServersSEP2018(int? id)
        {
            return View(new VServersListingViewModel
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilitySEP2018(id)

            });
        }

        //SEPTEMBER END SECTION



       

       
       

        
    }
}
