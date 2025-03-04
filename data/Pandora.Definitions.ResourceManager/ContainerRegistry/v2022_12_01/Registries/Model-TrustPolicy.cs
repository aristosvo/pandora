using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2022_12_01.Registries;


internal class TrustPolicyModel
{
    [JsonPropertyName("status")]
    public PolicyStatusConstant? Status { get; set; }

    [JsonPropertyName("type")]
    public TrustPolicyTypeConstant? Type { get; set; }
}
