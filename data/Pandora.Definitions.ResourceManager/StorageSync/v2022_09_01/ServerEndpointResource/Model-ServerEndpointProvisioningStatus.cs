using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.ServerEndpointResource;


internal class ServerEndpointProvisioningStatusModel
{
    [JsonPropertyName("provisioningStatus")]
    public ServerProvisioningStatusConstant? ProvisioningStatus { get; set; }

    [JsonPropertyName("provisioningStepStatuses")]
    public List<ServerEndpointProvisioningStepStatusModel>? ProvisioningStepStatuses { get; set; }

    [JsonPropertyName("provisioningType")]
    public string? ProvisioningType { get; set; }
}
