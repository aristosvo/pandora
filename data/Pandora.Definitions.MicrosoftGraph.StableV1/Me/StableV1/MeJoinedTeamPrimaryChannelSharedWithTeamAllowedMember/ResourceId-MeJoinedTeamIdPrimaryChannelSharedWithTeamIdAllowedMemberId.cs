// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeJoinedTeamPrimaryChannelSharedWithTeamAllowedMember;

internal class MeJoinedTeamIdPrimaryChannelSharedWithTeamIdAllowedMemberId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/joinedTeams/{teamId}/primaryChannel/sharedWithTeams/{sharedWithChannelTeamInfoId}/allowedMembers/{conversationMemberId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticJoinedTeams", "joinedTeams"),
        ResourceIDSegment.UserSpecified("teamId"),
        ResourceIDSegment.Static("staticPrimaryChannel", "primaryChannel"),
        ResourceIDSegment.Static("staticSharedWithTeams", "sharedWithTeams"),
        ResourceIDSegment.UserSpecified("sharedWithChannelTeamInfoId"),
        ResourceIDSegment.Static("staticAllowedMembers", "allowedMembers"),
        ResourceIDSegment.UserSpecified("conversationMemberId")
    };
}
