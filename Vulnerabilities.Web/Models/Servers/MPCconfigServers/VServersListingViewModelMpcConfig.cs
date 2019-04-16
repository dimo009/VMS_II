using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vulnerabilities.Services.Models.MPCconfigModels;

namespace Vulnerabilities.Web.Models.Servers.MPCconfigServers
{
    public class VServersListingViewModelMpcConfig
    {
        public IEnumerable<VServersListingModelMpcConfig> ServersAffectedByOneVulnerability { get; set; }
    }
}
