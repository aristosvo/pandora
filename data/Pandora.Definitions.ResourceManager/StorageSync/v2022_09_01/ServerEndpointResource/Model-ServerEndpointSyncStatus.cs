using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.ServerEndpointResource;


internal class ServerEndpointSyncStatusModel
{
    [JsonPropertyName("backgroundDataDownloadActivity")]
    public ServerEndpointBackgroundDataDownloadActivityModel? BackgroundDataDownloadActivity { get; set; }

    [JsonPropertyName("combinedHealth")]
    public ServerEndpointHealthStateConstant? CombinedHealth { get; set; }

    [JsonPropertyName("downloadActivity")]
    public ServerEndpointSyncActivityStatusModel? DownloadActivity { get; set; }

    [JsonPropertyName("downloadHealth")]
    public ServerEndpointHealthStateConstant? DownloadHealth { get; set; }

    [JsonPropertyName("downloadStatus")]
    public ServerEndpointSyncSessionStatusModel? DownloadStatus { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("lastUpdatedTimestamp")]
    public DateTime? LastUpdatedTimestamp { get; set; }

    [JsonPropertyName("offlineDataTransferStatus")]
    public ServerEndpointOfflineDataTransferStateConstant? OfflineDataTransferStatus { get; set; }

    [JsonPropertyName("syncActivity")]
    public ServerEndpointSyncActivityStateConstant? SyncActivity { get; set; }

    [JsonPropertyName("totalPersistentFilesNotSyncingCount")]
    public int? TotalPersistentFilesNotSyncingCount { get; set; }

    [JsonPropertyName("uploadActivity")]
    public ServerEndpointSyncActivityStatusModel? UploadActivity { get; set; }

    [JsonPropertyName("uploadHealth")]
    public ServerEndpointHealthStateConstant? UploadHealth { get; set; }

    [JsonPropertyName("uploadStatus")]
    public ServerEndpointSyncSessionStatusModel? UploadStatus { get; set; }
}
