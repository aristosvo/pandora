// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Applications.Beta.ApplicationAppManagementPolicy;

internal class Definition : ResourceDefinition
{
    public string Name => "ApplicationAppManagementPolicy";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AddApplicationByIdAppManagementPolicyRefOperation(),
        new GetApplicationByIdAppManagementPolicyCountOperation(),
        new ListApplicationByIdAppManagementPoliciesOperation(),
        new ListApplicationByIdAppManagementPolicyRefsOperation(),
        new RemoveApplicationByIdAppManagementPolicyByIdRefOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
