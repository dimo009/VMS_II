

namespace Vulnerabilities.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Vulnerabilities.Services.Contracts;
    using Web.Models.Servers.StandardEnvironmentServers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Vulnerabilities.Web.Models.Servers.MPCconfigServers;
    using Vulnerabilities.Web.Models.Servers.MPCpatchServers;

    [Route("Server")]
    public class ServerController : Controller
    {
        private const int pageSize = 25;

        private readonly IServerService servers;

        

        public ServerController(IServerService servers)
        {
            this.servers = servers;
            
        }

        //[HttpGet]
        //[Route(nameof(ImpactedServers))]
        //public IActionResult ImpactedServers(int? id)
        //{
           

        //    return View(new VServersListingViewModel
        //    {
        //        ServersAffectedByOneVulnerability = this.servers.AllServersAffectedByOneVulnerability(id),
        //        VulnId = id

        //    });
        //}

        [HttpGet]
        [Route(nameof(ImpactedServersSearch))]
        public IActionResult ImpactedServersSearch(int?id,string search, string searchBy)
        {
            if (search==null)
            {
                return View(new VServersListingViewModel
                {
                    ServersAffectedByOneVulnerability = this.servers.AllServersAffectedByOneVulnerability(id)

                });
            }
            
            else if (searchBy == "System name")
            {
                return View(new VServersListingViewModel
                {
                    
                    ServersAffectedByOneVulnerability = this.servers.AllServersAffectedByOneVulnerability(id)
                   .Where(s => s.SystemName.StartsWith(search) || search == null)

                });
            }

            else
            {
                return View(new VServersListingViewModel
                {
                    ServersAffectedByOneVulnerability = this.servers.AllServersAffectedByOneVulnerability(id)
                    .Where(s => s.TechnicalOwner.StartsWith(search) || search == null)

                });
            }
        }



        [HttpGet]
        [Route(nameof(ImpactedServersMpcConfig))]
        public IActionResult ImpactedServersMpcConfig(int? id)
        {
            return View(new VServersListingViewModelMpcConfig
            {
                ServersAffectedByOneVulnerability = this.servers.AllServersAffectedByOneVulnerabilityMpcConfig(id)

            });
        }

        [HttpGet]
        [Route(nameof(ImpactedServersMpcPatch))]
        public IActionResult ImpactedServersMpcPatch(int? id)
        {
            return View(new VServersListingViewModelMpcPatch
            {
                ServersAffectedByOneVulnerability = this.servers.AllServersAffectedByOneVulnerabilityMpcPatch(id)

            });
        }

       
    }

}

