using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HDInsight.v2018_06_01_preview.Extensions;


internal class AzureMonitorSelectedConfigurationsModel
{
    [JsonPropertyName("configurationVersion")]
    public string? ConfigurationVersion { get; set; }

    [JsonPropertyName("globalConfigurations")]
    public Dictionary<string, string>? GlobalConfigurations { get; set; }

    [JsonPropertyName("tableList")]
    public List<AzureMonitorTableConfigurationModel>? TableList { get; set; }
}
