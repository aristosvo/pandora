using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NetApp.v2023_07_01.VolumeQuotaRules;

internal class Definition : ResourceDefinition
{
    public string Name => "VolumeQuotaRules";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByVolumeOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
        typeof(TypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(VolumeQuotaRuleModel),
        typeof(VolumeQuotaRulePatchModel),
        typeof(VolumeQuotaRulesListModel),
        typeof(VolumeQuotaRulesPropertiesModel),
    };
}
