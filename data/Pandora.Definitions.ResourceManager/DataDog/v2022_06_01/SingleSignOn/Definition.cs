using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataDog.v2022_06_01.SingleSignOn;

internal class Definition : ResourceDefinition
{
    public string Name => "SingleSignOn";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ConfigurationsCreateOrUpdateOperation(),
        new ConfigurationsGetOperation(),
        new ConfigurationsListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
        typeof(SingleSignOnStatesConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DatadogSingleSignOnPropertiesModel),
        typeof(DatadogSingleSignOnResourceModel),
    };
}
