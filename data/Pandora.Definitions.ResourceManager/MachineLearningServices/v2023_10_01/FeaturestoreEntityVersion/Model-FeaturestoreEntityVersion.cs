using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.FeaturestoreEntityVersion;


internal class FeaturestoreEntityVersionModel
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("indexColumns")]
    public List<IndexColumnModel>? IndexColumns { get; set; }

    [JsonPropertyName("isAnonymous")]
    public bool? IsAnonymous { get; set; }

    [JsonPropertyName("isArchived")]
    public bool? IsArchived { get; set; }

    [JsonPropertyName("properties")]
    public Dictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("provisioningState")]
    public AssetProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    [JsonPropertyName("tags")]
    public CustomTypes.Tags? Tags { get; set; }
}
