using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2023_09_01_preview.AppPlatform;


internal class MonitoringSettingPropertiesModel
{
    [JsonPropertyName("appInsightsAgentVersions")]
    public ApplicationInsightsAgentVersionsModel? AppInsightsAgentVersions { get; set; }

    [JsonPropertyName("appInsightsInstrumentationKey")]
    public string? AppInsightsInstrumentationKey { get; set; }

    [JsonPropertyName("appInsightsSamplingRate")]
    public float? AppInsightsSamplingRate { get; set; }

    [JsonPropertyName("error")]
    public ErrorModel? Error { get; set; }

    [JsonPropertyName("provisioningState")]
    public MonitoringSettingStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("traceEnabled")]
    public bool? TraceEnabled { get; set; }
}
