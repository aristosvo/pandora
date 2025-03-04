using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2023_09_01_preview.AppPlatform;


internal class BuildServicePropertiesModel
{
    [JsonPropertyName("containerRegistry")]
    public string? ContainerRegistry { get; set; }

    [JsonPropertyName("kPackVersion")]
    public string? KPackVersion { get; set; }

    [JsonPropertyName("provisioningState")]
    public BuildServiceProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("resourceRequests")]
    public BuildServicePropertiesResourceRequestsModel? ResourceRequests { get; set; }
}
