using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NewRelic.v2022_07_01.Plan;


internal class PlanDataPropertiesModel
{
    [JsonPropertyName("accountCreationSource")]
    public AccountCreationSourceConstant? AccountCreationSource { get; set; }

    [JsonPropertyName("orgCreationSource")]
    public OrgCreationSourceConstant? OrgCreationSource { get; set; }

    [JsonPropertyName("planData")]
    public PlanDataModel? PlanData { get; set; }
}
