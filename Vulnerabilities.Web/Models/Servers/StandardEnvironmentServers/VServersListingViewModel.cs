namespace Vulnerabilities.Web.Models.Servers.StandardEnvironmentServers
{
   
    using System.Collections.Generic;
    using global::Vulnerabilities.Services.Models.StandardEnvironment;

    public class VServersListingViewModel
    {
        public IEnumerable<VServersListingModel> ServersAffectedByOneVulnerability { get; set; }

        //adding Vulnerability Id because of the search option

        public int? VulnId { get; set; }

    }
}
