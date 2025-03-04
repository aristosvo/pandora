using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApplicationInsights.v2015_05_01.ComponentFeaturesAndPricingAPIs;


internal class ApplicationInsightsComponentQuotaStatusModel
{
    [JsonPropertyName("AppId")]
    public string? AppId { get; set; }

    [JsonPropertyName("ExpirationTime")]
    public string? ExpirationTime { get; set; }

    [JsonPropertyName("ShouldBeThrottled")]
    public bool? ShouldBeThrottled { get; set; }
}
