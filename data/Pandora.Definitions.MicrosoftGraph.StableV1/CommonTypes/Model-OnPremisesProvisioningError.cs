// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class OnPremisesProvisioningErrorModel
{
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("occurredDateTime")]
    public DateTime? OccurredDateTime { get; set; }

    [JsonPropertyName("propertyCausingError")]
    public string? PropertyCausingError { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
