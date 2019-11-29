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


        //START REGION October 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigOctober2019))]
        public IActionResult SeverityFourMpcConfigOctober2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(10, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigOctober2019))]
        public IActionResult SeverityFiveMpcConfigOctober2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(10, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigOCT2019))]
        public IActionResult ImpactedServersMpcConfigOCT2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigOCT2019(id)

            });
        }


        //END REGION OCtober 2019


        //START REGION September 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigSeptember2019))]
        public IActionResult SeverityFourMpcConfigSeptember2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(9, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigSeptember2019))]
        public IActionResult SeverityFiveMpcConfigSeptember2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(9, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigSEP2019))]
        public IActionResult ImpactedServersMpcConfigSEP2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigSEP2019(id)

            });
        }


        //END REGION September 2019



        //START REGION August 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigAugust2019))]
        public IActionResult SeverityFourMpcConfigAugust2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(12, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigAugust2019))]
        public IActionResult SeverityFiveMpcConfigAugust2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(8, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigAUG2019))]
        public IActionResult ImpactedServersMpcConfigAUG2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigAUG2019(id)

            });
        }



        //END REGION August 2019


        //START REGION July 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigJuly2019))]
        public IActionResult SeverityFourMpcConfigJuly2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(7, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigJuly2019))]
        public IActionResult SeverityFiveMpcConfigJuly2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(7, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigJULY2019))]
        public IActionResult ImpactedServersMpcConfigJULY2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigJULY2019(id)

            });
        }



        //END REGION July 2019




        //START REGION June 2019

        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigJune2019))]
        public IActionResult SeverityFourMpcConfigJune2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(6, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigJune2019))]
        public IActionResult SeverityFiveMpcConfigJune2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(6, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigJUNE2019))]
        public IActionResult ImpactedServersMpcConfigJUNE2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigJUNE2019(id)

            });
        }

        //END REGION June 2019

        //START REGION May 2019


        [HttpGet]
        [Route(nameof(SeverityFourMpcConfigMay2019))]
        public IActionResult SeverityFourMpcConfigMay2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(5, 2019).Where(v => v.Severity == "4")
            });
        }

        [HttpGet]
        [Route(nameof(SeverityFiveMpcConfigMay2019))]
        public IActionResult SeverityFiveMpcConfigMay2019()
        {
            return View(new VulnerabilitiesListingViewModelMpcConfig
            {
                AllVulnerabilitiesMpcConfig = this.archives.AllVulnerabilitiesMpcConfig(5, 2019).Where(v => v.Severity == "5")
            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfigMAY2019))]
        public IActionResult ImpactedServersMpcConfigMAY2019(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.archives.AllServersAffectedByOneVulnerabilityMpcConfigMAY2019(id)

            });
        }

        //END REGION MAY 2019

       


       
       

     

       
    }
}
