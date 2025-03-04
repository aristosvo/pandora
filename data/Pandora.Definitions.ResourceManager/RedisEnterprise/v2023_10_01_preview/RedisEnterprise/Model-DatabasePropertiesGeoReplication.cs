using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2023_10_01_preview.RedisEnterprise;


internal class DatabasePropertiesGeoReplicationModel
{
    [JsonPropertyName("groupNickname")]
    public string? GroupNickname { get; set; }

    [JsonPropertyName("linkedDatabases")]
    public List<LinkedDatabaseModel>? LinkedDatabases { get; set; }
}
