using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.Provider;


internal class SiteConfigPropertiesDictionaryModel
{
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    [JsonPropertyName("powerShellVersion")]
    public string? PowerShellVersion { get; set; }

    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }
}
