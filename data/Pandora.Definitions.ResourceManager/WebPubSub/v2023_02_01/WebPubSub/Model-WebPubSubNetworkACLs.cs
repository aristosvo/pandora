using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.WebPubSub.v2023_02_01.WebPubSub;


internal class WebPubSubNetworkACLsModel
{
    [JsonPropertyName("defaultAction")]
    public ACLActionConstant? DefaultAction { get; set; }

    [JsonPropertyName("privateEndpoints")]
    public List<PrivateEndpointACLModel>? PrivateEndpoints { get; set; }

    [JsonPropertyName("publicNetwork")]
    public NetworkACLModel? PublicNetwork { get; set; }
}
