using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.VirtualMachineScaleSetExtensions;

internal class Definition : ResourceDefinition
{
    public string Name => "VirtualMachineScaleSetExtensions";
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

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(KeyVaultSecretReferenceModel),
        typeof(SubResourceModel),
        typeof(VirtualMachineScaleSetExtensionModel),
        typeof(VirtualMachineScaleSetExtensionPropertiesModel),
        typeof(VirtualMachineScaleSetExtensionUpdateModel),
    };
}
