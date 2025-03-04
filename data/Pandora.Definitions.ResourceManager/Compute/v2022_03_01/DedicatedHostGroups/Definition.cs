using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.DedicatedHostGroups;

internal class Definition : ResourceDefinition
{
    public string Name => "DedicatedHostGroups";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByResourceGroupOperation(),
        new ListBySubscriptionOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(InstanceViewTypesConstant),
        typeof(StatusLevelTypesConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DedicatedHostAllocatableVMModel),
        typeof(DedicatedHostAvailableCapacityModel),
        typeof(DedicatedHostGroupModel),
        typeof(DedicatedHostGroupInstanceViewModel),
        typeof(DedicatedHostGroupPropertiesModel),
        typeof(DedicatedHostGroupPropertiesAdditionalCapabilitiesModel),
        typeof(DedicatedHostGroupUpdateModel),
        typeof(DedicatedHostInstanceViewWithNameModel),
        typeof(InstanceViewStatusModel),
        typeof(SubResourceReadOnlyModel),
    };
}
