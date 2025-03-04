using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HDInsight.v2018_06_01_preview.Regions;


internal class ClusterCreateValidationResultModel
{
    [JsonPropertyName("aaddsResourcesDetails")]
    public List<AaddsResourceDetailsModel>? AaddsResourcesDetails { get; set; }

    [JsonPropertyName("estimatedCreationDuration")]
    public string? EstimatedCreationDuration { get; set; }

    [JsonPropertyName("validationErrors")]
    public List<ValidationErrorInfoModel>? ValidationErrors { get; set; }

    [JsonPropertyName("validationWarnings")]
    public List<ValidationErrorInfoModel>? ValidationWarnings { get; set; }
}
