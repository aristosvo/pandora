using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Batch.v2023_05_01.BatchAccount;


internal class EndpointAccessProfileModel
{
    [JsonPropertyName("defaultAction")]
    [Required]
    public EndpointAccessDefaultActionConstant DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public List<IPRuleModel>? IPRules { get; set; }
}
