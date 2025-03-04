using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_06_01.ReplicationProtectedItems;


internal class InMageAzureV2SwitchProviderDetailsModel
{
    [JsonPropertyName("targetApplianceId")]
    public string? TargetApplianceId { get; set; }

    [JsonPropertyName("targetFabricId")]
    public string? TargetFabricId { get; set; }

    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    [JsonPropertyName("targetVaultId")]
    public string? TargetVaultId { get; set; }
}
