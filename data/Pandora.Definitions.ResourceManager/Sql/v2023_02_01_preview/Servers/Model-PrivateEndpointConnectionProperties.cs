using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2023_02_01_preview.Servers;


internal class PrivateEndpointConnectionPropertiesModel
{
    [JsonPropertyName("groupIds")]
    public List<string>? GroupIds { get; set; }

    [JsonPropertyName("privateEndpoint")]
    public PrivateEndpointPropertyModel? PrivateEndpoint { get; set; }

    [JsonPropertyName("privateLinkServiceConnectionState")]
    public PrivateLinkServiceConnectionStatePropertyModel? PrivateLinkServiceConnectionState { get; set; }

    [JsonPropertyName("provisioningState")]
    public PrivateEndpointProvisioningStateConstant? ProvisioningState { get; set; }
}
