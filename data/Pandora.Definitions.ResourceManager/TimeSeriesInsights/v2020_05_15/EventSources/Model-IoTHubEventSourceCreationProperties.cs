using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.TimeSeriesInsights.v2020_05_15.EventSources;


internal class IoTHubEventSourceCreationPropertiesModel
{
    [JsonPropertyName("consumerGroupName")]
    [Required]
    public string ConsumerGroupName { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    [JsonPropertyName("eventSourceResourceId")]
    public string? EventSourceResourceId { get; set; }

    [JsonPropertyName("ingressStartAt")]
    public IngressStartAtPropertiesModel? IngressStartAt { get; set; }

    [JsonPropertyName("iotHubName")]
    [Required]
    public string IotHubName { get; set; }

    [JsonPropertyName("keyName")]
    [Required]
    public string KeyName { get; set; }

    [JsonPropertyName("localTimestamp")]
    public LocalTimestampModel? LocalTimestamp { get; set; }

    [JsonPropertyName("provisioningState")]
    public ProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("sharedAccessKey")]
    [Required]
    public string SharedAccessKey { get; set; }

    [JsonPropertyName("timestampPropertyName")]
    public string? TimestampPropertyName { get; set; }
}
