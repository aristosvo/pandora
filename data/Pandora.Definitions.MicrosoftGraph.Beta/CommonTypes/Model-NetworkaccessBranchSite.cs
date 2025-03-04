// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class NetworkaccessBranchSiteModel
{
    [JsonPropertyName("bandwidthCapacity")]
    public int? BandwidthCapacity { get; set; }

    [JsonPropertyName("connectivityConfiguration")]
    public NetworkaccessBranchConnectivityConfigurationModel? ConnectivityConfiguration { get; set; }

    [JsonPropertyName("connectivityState")]
    public NetworkaccessBranchSiteConnectivityStateConstant? ConnectivityState { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("deviceLinks")]
    public List<NetworkaccessDeviceLinkModel>? DeviceLinks { get; set; }

    [JsonPropertyName("forwardingProfiles")]
    public List<NetworkaccessForwardingProfileModel>? ForwardingProfiles { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("region")]
    public NetworkaccessBranchSiteRegionConstant? Region { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
