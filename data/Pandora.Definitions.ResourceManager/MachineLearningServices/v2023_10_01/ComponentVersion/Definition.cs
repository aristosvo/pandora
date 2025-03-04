using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.ComponentVersion;

internal class Definition : ResourceDefinition
{
    public string Name => "ComponentVersion";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new PublishOperation(),
        new RegistryComponentVersionsCreateOrUpdateOperation(),
        new RegistryComponentVersionsDeleteOperation(),
        new RegistryComponentVersionsGetOperation(),
        new RegistryComponentVersionsListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AssetProvisioningStateConstant),
        typeof(ListViewTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ComponentVersionModel),
        typeof(ComponentVersionResourceModel),
        typeof(DestinationAssetModel),
    };
}
