// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeProfilePosition;

internal class Definition : ResourceDefinition
{
    public string Name => "MeProfilePosition";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateMeProfilePositionOperation(),
        new DeleteMeProfilePositionByIdOperation(),
        new GetMeProfilePositionByIdOperation(),
        new GetMeProfilePositionCountOperation(),
        new ListMeProfilePositionsOperation(),
        new UpdateMeProfilePositionByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
