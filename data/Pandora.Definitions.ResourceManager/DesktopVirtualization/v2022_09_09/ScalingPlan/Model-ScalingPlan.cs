using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2022_09_09.ScalingPlan;


internal class ScalingPlanModel
{
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("identity")]
    public CustomTypes.SystemAssignedIdentity? Identity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public CustomTypes.Location? Location { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("plan")]
    public PlanModel? Plan { get; set; }

    [JsonPropertyName("properties")]
    [Required]
    public ScalingPlanPropertiesModel Properties { get; set; }

    [JsonPropertyName("sku")]
    public SkuModel? Sku { get; set; }

    [JsonPropertyName("systemData")]
    public CustomTypes.SystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public CustomTypes.Tags? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
