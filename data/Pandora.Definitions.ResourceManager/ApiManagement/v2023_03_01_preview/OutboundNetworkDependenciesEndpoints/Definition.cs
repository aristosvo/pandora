using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.OutboundNetworkDependenciesEndpoints;

internal class Definition : ResourceDefinition
{
    public string Name => "OutboundNetworkDependenciesEndpoints";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListByServiceOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(EndpointDependencyModel),
        typeof(EndpointDetailModel),
        typeof(OutboundEnvironmentEndpointModel),
        typeof(OutboundEnvironmentEndpointListModel),
    };
}
