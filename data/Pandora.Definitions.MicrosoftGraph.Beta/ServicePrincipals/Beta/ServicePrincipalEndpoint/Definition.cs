// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.ServicePrincipals.Beta.ServicePrincipalEndpoint;

internal class Definition : ResourceDefinition
{
    public string Name => "ServicePrincipalEndpoint";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateServicePrincipalByIdEndpointOperation(),
        new DeleteServicePrincipalByIdEndpointByIdOperation(),
        new GetServicePrincipalByIdEndpointByIdOperation(),
        new GetServicePrincipalByIdEndpointCountOperation(),
        new ListServicePrincipalByIdEndpointsOperation(),
        new UpdateServicePrincipalByIdEndpointByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
