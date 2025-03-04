using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabric.v2021_06_01.Service;


internal abstract class ServiceResourcePropertiesModel
{
    [JsonPropertyName("correlationScheme")]
    public List<ServiceCorrelationDescriptionModel>? CorrelationScheme { get; set; }

    [JsonPropertyName("defaultMoveCost")]
    public MoveCostConstant? DefaultMoveCost { get; set; }

    [JsonPropertyName("partitionDescription")]
    public PartitionSchemeDescriptionModel? PartitionDescription { get; set; }

    [JsonPropertyName("placementConstraints")]
    public string? PlacementConstraints { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("serviceDnsName")]
    public string? ServiceDnsName { get; set; }

    [JsonPropertyName("serviceKind")]
    [ProvidesTypeHint]
    [Required]
    public ServiceKindConstant ServiceKind { get; set; }

    [JsonPropertyName("serviceLoadMetrics")]
    public List<ServiceLoadMetricDescriptionModel>? ServiceLoadMetrics { get; set; }

    [JsonPropertyName("servicePackageActivationMode")]
    public ArmServicePackageActivationModeConstant? ServicePackageActivationMode { get; set; }

    [JsonPropertyName("servicePlacementPolicies")]
    public List<ServicePlacementPolicyDescriptionModel>? ServicePlacementPolicies { get; set; }

    [JsonPropertyName("serviceTypeName")]
    public string? ServiceTypeName { get; set; }
}
