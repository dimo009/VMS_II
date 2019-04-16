using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vulnerabilities.Services.Models.MPCpatchModels;

namespace Vulnerabilities.Web.Models.Servers.MPCpatchServers
{
    public class VServersListingViewModelMpcPatch
    {
        public IEnumerable<VServersListingModelMpcPatch> ServersAffectedByOneVulnerability { get; set; }
    }
}
