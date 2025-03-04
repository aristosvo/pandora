using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PaloAltoNetworks.v2023_09_01.PreRules;


internal class AppSeenDataModel
{
    [JsonPropertyName("appSeenList")]
    [Required]
    public List<AppSeenInfoModel> AppSeenList { get; set; }

    [JsonPropertyName("count")]
    [Required]
    public int Count { get; set; }
}
