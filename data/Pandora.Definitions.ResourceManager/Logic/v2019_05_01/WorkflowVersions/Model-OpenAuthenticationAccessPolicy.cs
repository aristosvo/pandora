using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Logic.v2019_05_01.WorkflowVersions;


internal class OpenAuthenticationAccessPolicyModel
{
    [JsonPropertyName("claims")]
    public List<OpenAuthenticationPolicyClaimModel>? Claims { get; set; }

    [JsonPropertyName("type")]
    public OpenAuthenticationProviderTypeConstant? Type { get; set; }
}
