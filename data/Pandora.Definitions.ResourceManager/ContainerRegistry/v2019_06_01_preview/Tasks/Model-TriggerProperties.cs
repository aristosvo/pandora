using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2019_06_01_preview.Tasks;


internal class TriggerPropertiesModel
{
    [JsonPropertyName("baseImageTrigger")]
    public BaseImageTriggerModel? BaseImageTrigger { get; set; }

    [JsonPropertyName("sourceTriggers")]
    public List<SourceTriggerModel>? SourceTriggers { get; set; }

    [JsonPropertyName("timerTriggers")]
    public List<TimerTriggerModel>? TimerTriggers { get; set; }
}
