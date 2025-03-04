using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Kusto.v2023_08_15.Clusters;


internal class OptimizedAutoscaleModel
{
    [JsonPropertyName("isEnabled")]
    [Required]
    public bool IsEnabled { get; set; }

    [JsonPropertyName("maximum")]
    [Required]
    public int Maximum { get; set; }

    [JsonPropertyName("minimum")]
    [Required]
    public int Minimum { get; set; }

    [JsonPropertyName("version")]
    [Required]
    public int Version { get; set; }
}
