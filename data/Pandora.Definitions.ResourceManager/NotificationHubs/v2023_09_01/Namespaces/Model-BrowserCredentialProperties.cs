using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NotificationHubs.v2023_09_01.Namespaces;


internal class BrowserCredentialPropertiesModel
{
    [JsonPropertyName("subject")]
    [Required]
    public string Subject { get; set; }

    [JsonPropertyName("vapidPrivateKey")]
    [Required]
    public string VapidPrivateKey { get; set; }

    [JsonPropertyName("vapidPublicKey")]
    [Required]
    public string VapidPublicKey { get; set; }
}
