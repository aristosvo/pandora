using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HybridKubernetes.v2024_01_01.ConnectedClusters;


internal class ArcAgentProfileModel
{
    [JsonPropertyName("agentAutoUpgrade")]
    public AutoUpgradeOptionsConstant? AgentAutoUpgrade { get; set; }

    [JsonPropertyName("desiredAgentVersion")]
    public string? DesiredAgentVersion { get; set; }
}
