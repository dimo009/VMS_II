using System;
using System.Collections.Generic;
using Vulnerabilities.Services.Models.MPCconfigModels;

namespace Vulnerabilities.Web.Models.Vulnerabilities.MPCconfigVulnerabilities
{

    public class VulnerabilitiesListingViewModelMpcConfig
    {
        public IEnumerable<VulnerabilityListingModelMpcConfig> AllVulnerabilitiesMpcConfig { get; set; }
    }
}
