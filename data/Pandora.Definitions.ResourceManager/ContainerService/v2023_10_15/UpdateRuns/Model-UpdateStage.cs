using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_10_15.UpdateRuns;


internal class UpdateStageModel
{
    [JsonPropertyName("afterStageWaitInSeconds")]
    public int? AfterStageWaitInSeconds { get; set; }

    [JsonPropertyName("groups")]
    public List<UpdateGroupModel>? Groups { get; set; }

    [JsonPropertyName("name")]
    [Required]
    public string Name { get; set; }
}
