using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StreamAnalytics.v2021_10_01_preview.Subscriptions;


internal class AzureFunctionOutputDataSourcePropertiesModel
{
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    [JsonPropertyName("functionAppName")]
    public string? FunctionAppName { get; set; }

    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    [JsonPropertyName("maxBatchCount")]
    public float? MaxBatchCount { get; set; }

    [JsonPropertyName("maxBatchSize")]
    public float? MaxBatchSize { get; set; }
}
