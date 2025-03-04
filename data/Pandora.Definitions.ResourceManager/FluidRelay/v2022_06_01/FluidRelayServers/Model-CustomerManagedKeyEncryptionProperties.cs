using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.FluidRelay.v2022_06_01.FluidRelayServers;


internal class CustomerManagedKeyEncryptionPropertiesModel
{
    [JsonPropertyName("keyEncryptionKeyIdentity")]
    public CustomerManagedKeyEncryptionPropertiesKeyEncryptionKeyIdentityModel? KeyEncryptionKeyIdentity { get; set; }

    [JsonPropertyName("keyEncryptionKeyUrl")]
    public string? KeyEncryptionKeyUrl { get; set; }
}
