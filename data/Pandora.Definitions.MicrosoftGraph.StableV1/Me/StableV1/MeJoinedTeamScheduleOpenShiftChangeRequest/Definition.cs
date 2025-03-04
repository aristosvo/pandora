// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeJoinedTeamScheduleOpenShiftChangeRequest;

internal class Definition : ResourceDefinition
{
    public string Name => "MeJoinedTeamScheduleOpenShiftChangeRequest";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateMeJoinedTeamByIdScheduleOpenShiftChangeRequestOperation(),
        new DeleteMeJoinedTeamByIdScheduleOpenShiftChangeRequestByIdOperation(),
        new GetMeJoinedTeamByIdScheduleOpenShiftChangeRequestByIdOperation(),
        new GetMeJoinedTeamByIdScheduleOpenShiftChangeRequestCountOperation(),
        new ListMeJoinedTeamByIdScheduleOpenShiftChangeRequestsOperation(),
        new UpdateMeJoinedTeamByIdScheduleOpenShiftChangeRequestByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
