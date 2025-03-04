using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_02_01.ReplicationProtectedItems;


internal class EnableProtectionInputPropertiesModel
{
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("protectableItemId")]
    public string? ProtectableItemId { get; set; }

    [JsonPropertyName("providerSpecificDetails")]
    public EnableProtectionProviderSpecificInputModel? ProviderSpecificDetails { get; set; }
}
