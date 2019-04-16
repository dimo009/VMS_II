
namespace Vulnerabilities.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Vulnerabilities.Services.Models.MPCconfigModels;
    using Vulnerabilities.Services.Models.MPCpatchModels;
    using Vulnerabilities.Services.Models.StandardEnvironment;

    public interface IServerService
    {
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerability(int?id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfig(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatch(int? id);

        

        int TotalPages(int?id);
    }
}
