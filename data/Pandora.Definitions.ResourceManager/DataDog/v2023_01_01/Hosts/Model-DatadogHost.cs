using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataDog.v2023_01_01.Hosts;


internal class DatadogHostModel
{
    [JsonPropertyName("aliases")]
    public List<string>? Aliases { get; set; }

    [JsonPropertyName("apps")]
    public List<string>? Apps { get; set; }

    [JsonPropertyName("meta")]
    public DatadogHostMetadataModel? Meta { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
