// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserCalendarViewAttachment;

internal class UserIdCalendarViewIdAttachmentId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/calendarView/{eventId}/attachments/{attachmentId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticCalendarView", "calendarView"),
        ResourceIDSegment.UserSpecified("eventId"),
        ResourceIDSegment.Static("staticAttachments", "attachments"),
        ResourceIDSegment.UserSpecified("attachmentId")
    };
}
