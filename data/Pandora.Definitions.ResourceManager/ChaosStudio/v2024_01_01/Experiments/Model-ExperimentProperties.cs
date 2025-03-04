using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2024_01_01.Experiments;


internal class ExperimentPropertiesModel
{
    [JsonPropertyName("provisioningState")]
    public ProvisioningStateConstant? ProvisioningState { get; set; }

    [MinItems(1)]
    [JsonPropertyName("selectors")]
    [Required]
    public List<SelectorModel> Selectors { get; set; }

    [MinItems(1)]
    [MaxItems(4)]
    [JsonPropertyName("steps")]
    [Required]
    public List<StepModel> Steps { get; set; }
}
