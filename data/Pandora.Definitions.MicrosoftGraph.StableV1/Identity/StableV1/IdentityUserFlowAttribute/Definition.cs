// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Identity.StableV1.IdentityUserFlowAttribute;

internal class Definition : ResourceDefinition
{
    public string Name => "IdentityUserFlowAttribute";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateIdentityUserFlowAttributeOperation(),
        new DeleteIdentityUserFlowAttributeByIdOperation(),
        new GetIdentityUserFlowAttributeByIdOperation(),
        new GetIdentityUserFlowAttributeCountOperation(),
        new ListIdentityUserFlowAttributesOperation(),
        new UpdateIdentityUserFlowAttributeByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
