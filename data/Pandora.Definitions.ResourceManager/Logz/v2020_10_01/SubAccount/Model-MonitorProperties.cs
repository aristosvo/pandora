using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Logz.v2020_10_01.SubAccount;


internal class MonitorPropertiesModel
{
    [JsonPropertyName("liftrResourceCategory")]
    public LiftrResourceCategoriesConstant? LiftrResourceCategory { get; set; }

    [JsonPropertyName("liftrResourcePreference")]
    public int? LiftrResourcePreference { get; set; }

    [JsonPropertyName("logzOrganizationProperties")]
    public LogzOrganizationPropertiesModel? LogzOrganizationProperties { get; set; }

    [JsonPropertyName("marketplaceSubscriptionStatus")]
    public MarketplaceSubscriptionStatusConstant? MarketplaceSubscriptionStatus { get; set; }

    [JsonPropertyName("monitoringStatus")]
    public MonitoringStatusConstant? MonitoringStatus { get; set; }

    [JsonPropertyName("planData")]
    public PlanDataModel? PlanData { get; set; }

    [JsonPropertyName("provisioningState")]
    public ProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("userInfo")]
    public UserInfoModel? UserInfo { get; set; }
}
