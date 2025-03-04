using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2023_07_01_preview.AppPlatform;

[ValueForType("AzureFileVolume")]
internal class AzureFileVolumeModel : CustomPersistentDiskPropertiesModel
{
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }
}
