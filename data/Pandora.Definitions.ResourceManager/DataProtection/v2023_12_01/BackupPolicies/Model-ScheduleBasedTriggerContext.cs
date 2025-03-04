using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_12_01.BackupPolicies;

[ValueForType("ScheduleBasedTriggerContext")]
internal class ScheduleBasedTriggerContextModel : TriggerContextModel
{
    [JsonPropertyName("schedule")]
    [Required]
    public BackupScheduleModel Schedule { get; set; }

    [JsonPropertyName("taggingCriteria")]
    [Required]
    public List<TaggingCriteriaModel> TaggingCriteria { get; set; }
}
