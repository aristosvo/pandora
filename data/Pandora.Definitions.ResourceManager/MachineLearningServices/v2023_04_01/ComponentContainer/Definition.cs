using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.ComponentContainer;

internal class Definition : ResourceDefinition
{
    public string Name => "ComponentContainer";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new RegistryComponentContainersCreateOrUpdateOperation(),
        new RegistryComponentContainersDeleteOperation(),
        new RegistryComponentContainersGetOperation(),
        new RegistryComponentContainersListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AssetProvisioningStateConstant),
        typeof(ListViewTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ComponentContainerModel),
        typeof(ComponentContainerResourceModel),
    };
}
