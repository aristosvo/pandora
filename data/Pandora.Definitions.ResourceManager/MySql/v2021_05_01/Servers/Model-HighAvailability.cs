using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MySql.v2021_05_01.Servers;


internal class HighAvailabilityModel
{
    [JsonPropertyName("mode")]
    public HighAvailabilityModeConstant? Mode { get; set; }

    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }

    [JsonPropertyName("state")]
    public HighAvailabilityStateConstant? State { get; set; }
}
