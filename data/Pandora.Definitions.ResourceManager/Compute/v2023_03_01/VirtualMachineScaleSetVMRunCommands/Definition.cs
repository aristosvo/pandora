using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2023_03_01.VirtualMachineScaleSetVMRunCommands;

internal class Definition : ResourceDefinition
{
    public string Name => "VirtualMachineScaleSetVMRunCommands";
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
        typeof(ExecutionStateConstant),
        typeof(StatusLevelTypesConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(InstanceViewStatusModel),
        typeof(RunCommandInputParameterModel),
        typeof(RunCommandManagedIdentityModel),
        typeof(VirtualMachineRunCommandModel),
        typeof(VirtualMachineRunCommandInstanceViewModel),
        typeof(VirtualMachineRunCommandPropertiesModel),
        typeof(VirtualMachineRunCommandScriptSourceModel),
        typeof(VirtualMachineRunCommandUpdateModel),
    };
}
