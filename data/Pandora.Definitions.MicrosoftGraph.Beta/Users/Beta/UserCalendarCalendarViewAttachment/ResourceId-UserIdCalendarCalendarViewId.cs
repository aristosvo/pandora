// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserCalendarCalendarViewAttachment;

internal class UserIdCalendarCalendarViewId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/calendar/calendarView/{eventId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticCalendar", "calendar"),
        ResourceIDSegment.Static("staticCalendarView", "calendarView"),
        ResourceIDSegment.UserSpecified("eventId")
    };
}
