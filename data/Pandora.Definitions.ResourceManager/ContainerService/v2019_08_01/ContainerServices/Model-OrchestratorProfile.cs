using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2019_08_01.ContainerServices;


internal class OrchestratorProfileModel
{
    [JsonPropertyName("isPreview")]
    public bool? IsPreview { get; set; }

    [JsonPropertyName("orchestratorType")]
    public string? OrchestratorType { get; set; }

    [JsonPropertyName("orchestratorVersion")]
    [Required]
    public string OrchestratorVersion { get; set; }
}
