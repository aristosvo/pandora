// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class Win32LobAppRestartSettingsModel
{
    [JsonPropertyName("countdownDisplayBeforeRestartInMinutes")]
    public int? CountdownDisplayBeforeRestartInMinutes { get; set; }

    [JsonPropertyName("gracePeriodInMinutes")]
    public int? GracePeriodInMinutes { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("restartNotificationSnoozeDurationInMinutes")]
    public int? RestartNotificationSnoozeDurationInMinutes { get; set; }
}
