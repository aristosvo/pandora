using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_06_01.ReplicationProtectedItems;

[ValueForType("A2A")]
internal class A2AAddDisksInputModel : AddDisksProviderSpecificInputModel
{
    [JsonPropertyName("vmDisks")]
    public List<A2AVMDiskInputDetailsModel>? VMDisks { get; set; }

    [JsonPropertyName("vmManagedDisks")]
    public List<A2AVMManagedDiskInputDetailsModel>? VMManagedDisks { get; set; }
}
