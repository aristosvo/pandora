using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.Devices;


internal class GenerateCertResponseModel
{
    [JsonPropertyName("expiryTimeInUTC")]
    public string? ExpiryTimeInUTC { get; set; }

    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }
}
