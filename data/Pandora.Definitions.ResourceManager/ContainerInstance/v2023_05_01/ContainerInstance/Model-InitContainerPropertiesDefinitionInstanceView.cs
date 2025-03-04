using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerInstance.v2023_05_01.ContainerInstance;


internal class InitContainerPropertiesDefinitionInstanceViewModel
{
    [JsonPropertyName("currentState")]
    public ContainerStateModel? CurrentState { get; set; }

    [JsonPropertyName("events")]
    public List<EventModel>? Events { get; set; }

    [JsonPropertyName("previousState")]
    public ContainerStateModel? PreviousState { get; set; }

    [JsonPropertyName("restartCount")]
    public int? RestartCount { get; set; }
}
