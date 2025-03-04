using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PaloAltoNetworks.v2023_09_01.LocalRulestacks;


internal class PredefinedUrlCategoryModel
{
    [JsonPropertyName("action")]
    [Required]
    public string Action { get; set; }

    [JsonPropertyName("name")]
    [Required]
    public string Name { get; set; }
}
