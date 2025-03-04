using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2023_11_01.SourceControl;


internal class SourceControlCreateOrUpdatePropertiesModel
{
    [JsonPropertyName("autoSync")]
    public bool? AutoSync { get; set; }

    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("folderPath")]
    public string? FolderPath { get; set; }

    [JsonPropertyName("publishRunbook")]
    public bool? PublishRunbook { get; set; }

    [JsonPropertyName("repoUrl")]
    public string? RepoUrl { get; set; }

    [JsonPropertyName("securityToken")]
    public SourceControlSecurityTokenPropertiesModel? SecurityToken { get; set; }

    [JsonPropertyName("sourceType")]
    public SourceTypeConstant? SourceType { get; set; }
}
