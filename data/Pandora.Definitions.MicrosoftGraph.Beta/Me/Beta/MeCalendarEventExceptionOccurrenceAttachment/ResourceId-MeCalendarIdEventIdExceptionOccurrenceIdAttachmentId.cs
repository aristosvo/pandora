// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeCalendarEventExceptionOccurrenceAttachment;

internal class MeCalendarIdEventIdExceptionOccurrenceIdAttachmentId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/calendars/{calendarId}/events/{eventId}/exceptionOccurrences/{eventId1}/attachments/{attachmentId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticCalendars", "calendars"),
        ResourceIDSegment.UserSpecified("calendarId"),
        ResourceIDSegment.Static("staticEvents", "events"),
        ResourceIDSegment.UserSpecified("eventId"),
        ResourceIDSegment.Static("staticExceptionOccurrences", "exceptionOccurrences"),
        ResourceIDSegment.UserSpecified("eventId1"),
        ResourceIDSegment.Static("staticAttachments", "attachments"),
        ResourceIDSegment.UserSpecified("attachmentId")
    };
}
