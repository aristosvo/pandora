// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeOnlineMeetingRecordingContent;

internal class MeOnlineMeetingIdRecordingId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/onlineMeetings/{onlineMeetingId}/recordings/{callRecordingId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticOnlineMeetings", "onlineMeetings"),
        ResourceIDSegment.UserSpecified("onlineMeetingId"),
        ResourceIDSegment.Static("staticRecordings", "recordings"),
        ResourceIDSegment.UserSpecified("callRecordingId")
    };
}
