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

        //START REGION FEBRUARY 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchFebruary2019))]
        public IActionResult SeverityFourMpcPatchFebruary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(2, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchFebruary2019))]
        public IActionResult SeverityFiveMpcPatchFebruary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(2, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchFEB2019))]
        public IActionResult ImpactedServersMpcPatchFEB2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchFEB2019(id)

            });
        }

        //END REGION JANUARY 2019


        //START REGION JANUARY 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchJanuary2019))]
        public IActionResult SeverityFourMpcPatchJanuary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(1, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchJanuary2019))]
        public IActionResult SeverityFiveMpcPatchJanuary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(1, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchJAN2019))]
        public IActionResult ImpactedServersMpcPatchJAN2019(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchJAN2019(id)

            });
        }

        //END REGION JANUARY 2019

        //START REGION DECEMBER 2018

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchDecember2018))]
        public IActionResult SeverityFourMpcPatchDecember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(12, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchDecember2018))]
        public IActionResult SeverityFiveMpcPatchDecember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(12, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchDEC2018))]
        public IActionResult ImpactedServersMpcPatchDEC2018(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchDEC2018(id)

            });
        }

        //END REGION DECEMBER 2018


        //START REGION NOVEMBER 2018

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchNovember2018))]
        public IActionResult SeverityFourMpcPatchNovember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(11, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchNovember2018))]
        public IActionResult SeverityFiveMpcPatchNovember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(11, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchNOV2018))]
        public IActionResult ImpactedServersMpcPatchNOV2018(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchNOV2018(id)

            });
        }

        //END REGION NOVEMBER 2018


        //START REGION OCTOBER 2018

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchOctober2018))]
        public IActionResult SeverityFourMpcPatchOctober2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(10, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchOctober2018))]
        public IActionResult SeverityFiveMpcPatchOctober2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(10, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchOCT2018))]
        public IActionResult ImpactedServersMpcPatchOCT2018(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchOCT2018(id)

            });
        }

        //END REGION OCTOBER 2018

        //Start region SEPTEMBER 2018

        [HttpGet]
        [Route(nameof(SeverityFourMpcPatchSeptember2018))]
        public IActionResult SeverityFourMpcPatchSeptember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(9, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcPatchSeptember2018))]
        public IActionResult SeverityFiveMpcPatchSeptember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcPatch
            {
                AllVulnerabilitiesMpcPatch = this.archives.AllVulnerabilitiesMpcPatch(9, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatchSEP2018))]
        public IActionResult ImpactedServersMpcPatchSEP2018(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcPatchSEP2018(id)

            });
        }


        //END REGION SEPTEMBER 2018


  

      


      

       

       
    }
}
