using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_05_01.BackupPolicies;


internal class BackupScheduleModel
{
    [JsonPropertyName("repeatingTimeIntervals")]
    [Required]
    public List<string> RepeatingTimeIntervals { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}
