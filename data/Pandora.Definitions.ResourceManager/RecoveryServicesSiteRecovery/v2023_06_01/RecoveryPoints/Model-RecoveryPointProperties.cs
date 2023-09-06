using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_06_01.RecoveryPoints;


internal class RecoveryPointPropertiesModel
{
    [JsonPropertyName("providerSpecificDetails")]
    public ProviderSpecificRecoveryPointDetailsModel? ProviderSpecificDetails { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("recoveryPointTime")]
    public DateTime? RecoveryPointTime { get; set; }

    [JsonPropertyName("recoveryPointType")]
    public string? RecoveryPointType { get; set; }
}
