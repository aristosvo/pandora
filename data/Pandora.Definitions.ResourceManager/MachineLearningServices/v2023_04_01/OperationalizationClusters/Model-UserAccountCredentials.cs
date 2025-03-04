using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.OperationalizationClusters;


internal class UserAccountCredentialsModel
{
    [JsonPropertyName("adminUserName")]
    [Required]
    public string AdminUserName { get; set; }

    [JsonPropertyName("adminUserPassword")]
    public string? AdminUserPassword { get; set; }

    [JsonPropertyName("adminUserSshPublicKey")]
    public string? AdminUserSshPublicKey { get; set; }
}
