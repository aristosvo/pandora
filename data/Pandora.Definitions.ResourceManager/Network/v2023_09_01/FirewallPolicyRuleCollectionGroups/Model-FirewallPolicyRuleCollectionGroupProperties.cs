using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.FirewallPolicyRuleCollectionGroups;


internal class FirewallPolicyRuleCollectionGroupPropertiesModel
{
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("provisioningState")]
    public ProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("ruleCollections")]
    public List<FirewallPolicyRuleCollectionModel>? RuleCollections { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }
}
