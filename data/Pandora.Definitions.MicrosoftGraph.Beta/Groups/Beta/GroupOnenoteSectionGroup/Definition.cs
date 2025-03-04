// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupOnenoteSectionGroup;

internal class Definition : ResourceDefinition
{
    public string Name => "GroupOnenoteSectionGroup";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateGroupByIdOnenoteSectionGroupOperation(),
        new DeleteGroupByIdOnenoteSectionGroupByIdOperation(),
        new GetGroupByIdOnenoteSectionGroupByIdOperation(),
        new GetGroupByIdOnenoteSectionGroupCountOperation(),
        new ListGroupByIdOnenoteSectionGroupsOperation(),
        new UpdateGroupByIdOnenoteSectionGroupByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
