// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupOnenoteNotebookSectionPage;

internal class CreateGroupByIdOnenoteNotebookByIdSectionByIdPageByIdCopyToSectionRequestModel
{
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("siteCollectionId")]
    public string? SiteCollectionId { get; set; }

    [JsonPropertyName("siteId")]
    public string? SiteId { get; set; }
}
