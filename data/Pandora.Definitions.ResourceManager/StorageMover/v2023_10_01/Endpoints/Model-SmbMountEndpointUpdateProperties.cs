using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageMover.v2023_10_01.Endpoints;

[ValueForType("SmbMount")]
internal class SmbMountEndpointUpdatePropertiesModel : EndpointBaseUpdatePropertiesModel
{
    [JsonPropertyName("credentials")]
    public AzureKeyVaultSmbCredentialsModel? Credentials { get; set; }
}
