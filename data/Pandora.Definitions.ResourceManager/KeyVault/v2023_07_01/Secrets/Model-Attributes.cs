using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KeyVault.v2023_07_01.Secrets;


internal class AttributesModel
{
    [JsonPropertyName("created")]
    public int? Created { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("exp")]
    public int? Exp { get; set; }

    [JsonPropertyName("nbf")]
    public int? Nbf { get; set; }

    [JsonPropertyName("updated")]
    public int? Updated { get; set; }
}
