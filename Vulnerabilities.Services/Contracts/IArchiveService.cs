

namespace Vulnerabilities.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Vulnerabilities.Services.Models.MPCconfigModels;
    using Vulnerabilities.Services.Models.MPCpatchModels;
    using Vulnerabilities.Services.Models.StandardEnvironment;

    public interface IArchiveService
    {
        IEnumerable<VulnerabilityListingModel> AllVulnerabilities(int month, int currentYear);
        IEnumerable<VulnerabilityListingModelMpcConfig> AllVulnerabilitiesMpcConfig(int month, int currentYear);
        IEnumerable<VulnerabilityListingModelMpcPatch> AllVulnerabilitiesMpcPatch(int month, int currentYear);

        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityOCT2019(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilitySEP2019(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityAUG2019(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityJULY2019(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityJUNE2019(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityMAY2019(int? id);


        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigOCT2019(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigSEP2019(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigAUG2019(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigJULY2019(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigJUNE2019(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigMAY2019(int? id);



        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchOCT2019(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchSEP2019(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchAUG2019(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchJULY2019(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchJUNE2019(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchMAY2019(int? id);
      
       
        






    }
}
