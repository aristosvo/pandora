using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2023_01_01.StorageAccounts;


internal class GeoReplicationStatsModel
{
    [JsonPropertyName("canFailover")]
    public bool? CanFailover { get; set; }

    [JsonPropertyName("canPlannedFailover")]
    public bool? CanPlannedFailover { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("lastSyncTime")]
    public DateTime? LastSyncTime { get; set; }

    [JsonPropertyName("postFailoverRedundancy")]
    public PostFailoverRedundancyConstant? PostFailoverRedundancy { get; set; }

    [JsonPropertyName("postPlannedFailoverRedundancy")]
    public PostPlannedFailoverRedundancyConstant? PostPlannedFailoverRedundancy { get; set; }

    [JsonPropertyName("status")]
    public GeoReplicationStatusConstant? Status { get; set; }
}
