

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

        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityFEB2019(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityJAN2019(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityDEC2018(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityNOV2018(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilityOCT2018(int? id);
        IEnumerable<VServersListingModel> AllServersAffectedByOneVulnerabilitySEP2018(int? id);


        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigFEB2019(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigJAN2019(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigDEC2018(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigNOV2018(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigOCT2018(int? id);
        IEnumerable<VServersListingModelMpcConfig> AllServersAffectedByOneVulnerabilityMpcConfigSEP2018(int? id);



        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchFEB2019(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchJAN2019(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchDEC2018(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchNOV2018(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchOCT2018(int? id);
        IEnumerable<VServersListingModelMpcPatch> AllServersAffectedByOneVulnerabilityMpcPatchSEP2018(int? id);
      
       
        






    }
}
