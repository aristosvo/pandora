using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2022_08_08.SoftwareUpdateConfigurationMachineRun;

internal class Definition : ResourceDefinition
{
    public string Name => "SoftwareUpdateConfigurationMachineRun";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetByIdOperation(),
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ErrorResponseModel),
        typeof(JobNavigationModel),
        typeof(SoftwareUpdateConfigurationMachineRunModel),
        typeof(SoftwareUpdateConfigurationMachineRunListResultModel),
        typeof(UpdateConfigurationMachineRunPropertiesModel),
        typeof(UpdateConfigurationNavigationModel),
    };
}
