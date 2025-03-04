using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataDog.v2023_01_01.Hosts;


internal class DatadogHostMetadataModel
{
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    [JsonPropertyName("installMethod")]
    public DatadogInstallMethodModel? InstallMethod { get; set; }

    [JsonPropertyName("logsAgent")]
    public DatadogLogsAgentModel? LogsAgent { get; set; }
}
