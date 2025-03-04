using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ElasticSan.v2023_01_01.Snapshots;


internal class SnapshotPropertiesModel
{
    [JsonPropertyName("creationData")]
    [Required]
    public SnapshotCreationDataModel CreationData { get; set; }

    [JsonPropertyName("provisioningState")]
    public ProvisioningStatesConstant? ProvisioningState { get; set; }

    [JsonPropertyName("sourceVolumeSizeGiB")]
    public int? SourceVolumeSizeGiB { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}
