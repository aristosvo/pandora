using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Dashboard.v2023_09_01.GrafanaResource;


internal class EnterpriseConfigurationsModel
{
    [JsonPropertyName("marketplaceAutoRenew")]
    public MarketplaceAutoRenewConstant? MarketplaceAutoRenew { get; set; }

    [JsonPropertyName("marketplacePlanId")]
    public string? MarketplacePlanId { get; set; }
}
