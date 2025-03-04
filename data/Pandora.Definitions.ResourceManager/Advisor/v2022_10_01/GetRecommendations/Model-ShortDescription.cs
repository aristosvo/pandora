using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Advisor.v2022_10_01.GetRecommendations;


internal class ShortDescriptionModel
{
    [JsonPropertyName("problem")]
    public string? Problem { get; set; }

    [JsonPropertyName("solution")]
    public string? Solution { get; set; }
}
