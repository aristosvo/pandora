// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserJoinedTeamChannelMember;

internal class ListUserByIdJoinedTeamByIdChannelByIdMembersOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new UserIdJoinedTeamIdChannelId();
    public override Type NestedItemType() => typeof(ConversationMemberCollectionResponseModel);
    public override string? UriSuffix() => "/members";
}
