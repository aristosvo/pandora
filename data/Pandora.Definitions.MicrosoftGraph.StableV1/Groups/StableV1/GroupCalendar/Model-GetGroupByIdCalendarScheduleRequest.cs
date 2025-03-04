// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupCalendar;

internal class GetGroupByIdCalendarScheduleRequestModel
{
    [JsonPropertyName("AvailabilityViewInterval")]
    public int? AvailabilityViewInterval { get; set; }

    [JsonPropertyName("EndTime")]
    public DateTimeTimeZoneModel? EndTime { get; set; }

    [JsonPropertyName("Schedules")]
    public List<string>? Schedules { get; set; }

    [JsonPropertyName("StartTime")]
    public DateTimeTimeZoneModel? StartTime { get; set; }
}
