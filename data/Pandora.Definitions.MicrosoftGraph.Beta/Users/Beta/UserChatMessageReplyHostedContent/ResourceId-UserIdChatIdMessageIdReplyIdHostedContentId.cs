// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserChatMessageReplyHostedContent;

internal class UserIdChatIdMessageIdReplyIdHostedContentId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/chats/{chatId}/messages/{chatMessageId}/replies/{chatMessageId1}/hostedContents/{chatMessageHostedContentId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticChats", "chats"),
        ResourceIDSegment.UserSpecified("chatId"),
        ResourceIDSegment.Static("staticMessages", "messages"),
        ResourceIDSegment.UserSpecified("chatMessageId"),
        ResourceIDSegment.Static("staticReplies", "replies"),
        ResourceIDSegment.UserSpecified("chatMessageId1"),
        ResourceIDSegment.Static("staticHostedContents", "hostedContents"),
        ResourceIDSegment.UserSpecified("chatMessageHostedContentId")
    };
}
