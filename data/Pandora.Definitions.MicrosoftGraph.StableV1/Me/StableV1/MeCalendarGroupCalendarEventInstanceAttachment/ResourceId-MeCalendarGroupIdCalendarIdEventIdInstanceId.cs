// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeCalendarGroupCalendarEventInstanceAttachment;

internal class MeCalendarGroupIdCalendarIdEventIdInstanceId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/events/{eventId}/instances/{eventId1}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticCalendarGroups", "calendarGroups"),
        ResourceIDSegment.UserSpecified("calendarGroupId"),
        ResourceIDSegment.Static("staticCalendars", "calendars"),
        ResourceIDSegment.UserSpecified("calendarId"),
        ResourceIDSegment.Static("staticEvents", "events"),
        ResourceIDSegment.UserSpecified("eventId"),
        ResourceIDSegment.Static("staticInstances", "instances"),
        ResourceIDSegment.UserSpecified("eventId1")
    };
}
