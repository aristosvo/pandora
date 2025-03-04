using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.TenantConfigurationSyncState;

internal class Definition : ResourceDefinition
{
    public string Name => "TenantConfigurationSyncState";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new TenantConfigurationGetSyncStateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(TenantConfigurationSyncStateContractModel),
        typeof(TenantConfigurationSyncStateContractPropertiesModel),
    };
}
