using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2021_11_01.VirtualMachineExtensions;

internal class Definition : ResourceDefinition
{
    public string Name => "VirtualMachineExtensions";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(StatusLevelTypesConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(InstanceViewStatusModel),
        typeof(VirtualMachineExtensionModel),
        typeof(VirtualMachineExtensionInstanceViewModel),
        typeof(VirtualMachineExtensionPropertiesModel),
        typeof(VirtualMachineExtensionUpdateModel),
        typeof(VirtualMachineExtensionUpdatePropertiesModel),
        typeof(VirtualMachineExtensionsListResultModel),
    };
}
