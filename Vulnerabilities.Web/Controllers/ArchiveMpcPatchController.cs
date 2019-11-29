using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vulnerabilites.Data.Context;
using Vulnerabilities.Services.Contracts;
using Vulnerabilities.Web.Models.Servers.MPCpatchServers;
using Vulnerabilities.Web.Models.Vulnerabilities.MPCpatchVulnerabilities;

namespace Vulnerabilities.Web.Controllers
{
    public class ArchiveMpcPatchController:Controller
    {
        private readonly IArchiveService archives;  
        private readonly MPCMissingPatchDbContext mpcPatchDB;


        public ArchiveMpcPatchController(IArchiveService archives, MPCMissingPatchDbContext mpcPatchDB)
        {
            this.archives = archives;
            this.mpcPatchDB = mpcPatchDB;
        }

        //START REGION October 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchOctober2019))]
        public IActionResult SeverityFourMpcPatchOctober2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(10, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchOctober2019))]
        public IActionResult SeverityFiveMpcPatchOctober2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(10, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchOCT2019))]
        public IActionResult ImpactedServersMpcPatchOCT2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchOCT2019(id)

            });
        }

        //END REGION September 2019


        //START REGION September 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchSeptember2019))]
        public IActionResult SeverityFourMpcPatchSeptember2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(9, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchSeptember2019))]
        public IActionResult SeverityFiveMpcPatchSeptember2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(9, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchSEP2019))]
        public IActionResult ImpactedServersMpcPatchSEP2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchSEP2019(id)

            });
        }

        //END REGION September 2019

        //START REGION August 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchAugust2019))]
        public IActionResult SeverityFourMpcPatchAugust2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(8, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchAugust2019))]
        public IActionResult SeverityFiveMpcPatchAugust2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(8, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchAUG2019))]
        public IActionResult ImpactedServersMpcPatchAUG2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchAUG2019(id)

            });
        }

        //END REGION August 2019


        //START REGION July 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchJuly2019))]
        public IActionResult SeverityFourMpcPatchJuly2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(7, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchJuly2019))]
        public IActionResult SeverityFiveMpcPatchJuly2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(7, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchJULY2019))]
        public IActionResult ImpactedServersMpcPatchJULY2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchJULY2019(id)

            });
        }

        //END REGION July 2019


        //START REGION JUNE 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchJune2019))]
        public IActionResult SeverityFourMpcPatchJune2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(6, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchJune2019))]
        public IActionResult SeverityFiveMpcPatchJune2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(6, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchJUNE2019))]
        public IActionResult ImpactedServersMpcPatchJUNE2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchJUNE2019(id)

            });
        }

        //END REGION JUNE 2019

        //Start region SEPTEMBER 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchMay2019))]
        public IActionResult SeverityFourMpcPatchMay2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(5, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchMay2019))]
        public IActionResult SeverityFiveMpcPatchMay2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(5, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchMAY2019))]
        public IActionResult ImpactedServersMpcPatchMAY2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchMAY2019(id)

            });
        }


        //END REGION SEPTEMBER 2019


  

      


      

       

       
    }
}
