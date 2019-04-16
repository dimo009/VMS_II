using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vulnerabilities.Services.Models.MPCpatchModels;

namespace Vulnerabilities.Web.Models.Vulnerabilities.MPCpatchVulnerabilities
{
    public class VulnerabilitiesListingViewModelMpcPatch
    {
        public IEnumerable<VulnerabilityListingModelMpcPatch> AllVulnerabilitiesMpcPatch { get; set; }
    }
}
