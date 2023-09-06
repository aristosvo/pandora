using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ResourceGraph.v2022_10_01.Resources;


internal class QueryRequestModel
{
    [JsonPropertyName("facets")]
    public List<FacetRequestModel>? Facets { get; set; }

    [JsonPropertyName("managementGroups")]
    public List<string>? ManagementGroups { get; set; }

    [JsonPropertyName("options")]
    public QueryRequestOptionsModel? Options { get; set; }

    [JsonPropertyName("query")]
    [Required]
    public string Query { get; set; }

    [JsonPropertyName("subscriptions")]
    public List<string>? Subscriptions { get; set; }
}
