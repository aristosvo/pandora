using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.StaticSites;


internal class ResponseMessageEnvelopeRemotePrivateEndpointConnectionModel
{
    [JsonPropertyName("error")]
    public ErrorEntityModel? Error { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("identity")]
    public CustomTypes.SystemAndUserAssignedIdentityMap? Identity { get; set; }

    [JsonPropertyName("location")]
    public CustomTypes.Location? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("plan")]
    public ArmPlanModel? Plan { get; set; }

    [JsonPropertyName("properties")]
    public RemotePrivateEndpointConnectionModel? Properties { get; set; }

    [JsonPropertyName("sku")]
    public SkuDescriptionModel? Sku { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("tags")]
    public CustomTypes.Tags? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("zones")]
    public CustomTypes.Zones? Zones { get; set; }
}
