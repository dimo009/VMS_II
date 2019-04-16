

namespace Vulnerabilities.Web.Models.Vulnerabilities.StandardEnvironmentVulnerabilities
{
    using global::Vulnerabilities.Services.Models.StandardEnvironment;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    

    public class VulnerabilitiesListingViewModel
    {
        public IEnumerable<VulnerabilityListingModel> AllVulnerabilities { get; set; }
    }
}
