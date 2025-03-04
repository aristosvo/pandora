using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.Issue;


internal class IssueContractPropertiesModel
{
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    [JsonPropertyName("description")]
    [Required]
    public string Description { get; set; }

    [JsonPropertyName("state")]
    public StateConstant? State { get; set; }

    [JsonPropertyName("title")]
    [Required]
    public string Title { get; set; }

    [JsonPropertyName("userId")]
    [Required]
    public string UserId { get; set; }
}
