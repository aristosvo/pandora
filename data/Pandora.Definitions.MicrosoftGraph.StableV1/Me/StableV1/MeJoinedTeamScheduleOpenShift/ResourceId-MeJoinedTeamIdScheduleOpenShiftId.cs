// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeJoinedTeamScheduleOpenShift;

internal class MeJoinedTeamIdScheduleOpenShiftId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/joinedTeams/{teamId}/schedule/openShifts/{openShiftId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticJoinedTeams", "joinedTeams"),
        ResourceIDSegment.UserSpecified("teamId"),
        ResourceIDSegment.Static("staticSchedule", "schedule"),
        ResourceIDSegment.Static("staticOpenShifts", "openShifts"),
        ResourceIDSegment.UserSpecified("openShiftId")
    };
}
