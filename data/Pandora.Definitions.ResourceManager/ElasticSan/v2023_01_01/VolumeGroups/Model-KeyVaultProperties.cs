using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ElasticSan.v2023_01_01.VolumeGroups;


internal class KeyVaultPropertiesModel
{
    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("currentVersionedKeyExpirationTimestamp")]
    public DateTime? CurrentVersionedKeyExpirationTimestamp { get; set; }

    [JsonPropertyName("currentVersionedKeyIdentifier")]
    public string? CurrentVersionedKeyIdentifier { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("keyVaultUri")]
    public string? KeyVaultUri { get; set; }

    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("lastKeyRotationTimestamp")]
    public DateTime? LastKeyRotationTimestamp { get; set; }
}
