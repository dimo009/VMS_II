using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vulnerabilites.Data.Context;
using Vulnerabilities.Services.Contracts;
using Vulnerabilities.Web.Models.Servers.MPCconfigServers;
using Vulnerabilities.Web.Models.Vulnerabilities.MPCconfigVulnerabilities;

namespace Vulnerabilities.Web.Controllers
{
    public class ArchiveMpcConfigController:Controller
    {
        private readonly IArchiveService archives;
        private readonly MpcDBContext mpcConfigDB;
        


        public ArchiveMpcConfigController(IArchiveService archives, MpcDBContext mpcConfigDB)
        {
            this.archives = archives;
            this.mpcConfigDB = mpcConfigDB;
        }


        //START REGION February 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigFebruary2019))]
        public IActionResult SeverityFourMpcConfigFebruary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(2, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigFebruary2019))]
        public IActionResult SeverityFiveMpcConfigFebruary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(2, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigFEB2019))]
        public IActionResult ImpactedServersMpcConfigFEB2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigFEB2019(id)

            });
        }


        //END REGION JANUARY 2019


        //START REGION JANUARY 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigJanuary2019))]
        public IActionResult SeverityFourMpcConfigJanuary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(1, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigJanuary2019))]
        public IActionResult SeverityFiveMpcConfigJanuary2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(1, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigJAN2019))]
        public IActionResult ImpactedServersMpcConfigJAN2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigJAN2019(id)

            });
        }


        //END REGION JANUARY 2019



        //START REGION DECEMBER 2018

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigDecember2018))]
        public IActionResult SeverityFourMpcConfigDecember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(12, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigDecember2018))]
        public IActionResult SeverityFiveMpcConfigDecember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(12, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigDEC2018))]
        public IActionResult ImpactedServersMpcConfigDEC2018(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigDEC2018(id)

            });
        }



        //END REGION DECEMBER 2018


        //START REGION NOVEMBER 2018

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigNovember2018))]
        public IActionResult SeverityFourMpcConfigNovember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(11, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigNovember2018))]
        public IActionResult SeverityFiveMpcConfigNovember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(11, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigNOV2018))]
        public IActionResult ImpactedServersMpcConfigNOV2018(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigNOV2018(id)

            });
        }



        //END REGION NOVEMBER 2018




        //START REGION OCTOBER 2018

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigOctober2018))]
        public IActionResult SeverityFourMpcConfigOctober2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(10, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigOctober2018))]
        public IActionResult SeverityFiveMpcConfigOctober2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(10, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigOCT2018))]
        public IActionResult ImpactedServersMpcConfigOCT2018(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigOCT2018(id)

            });
        }

        //END REGION OCTOBER 2018

        //START REGION SEPTEMBER 2018


        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigSeptember2018))]
        public IActionResult SeverityFourMpcConfigSeptember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(9, 2018).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigSeptember2018))]
        public IActionResult SeverityFiveMpcConfigSeptember2018()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(9, 2018).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigSEP2018))]
        public IActionResult ImpactedServersMpcConfigSEP2018(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigSEP2018(id)

            });
        }

        //END REGION SEPTEMBER 2018

       


       
       

     

       
    }
}
