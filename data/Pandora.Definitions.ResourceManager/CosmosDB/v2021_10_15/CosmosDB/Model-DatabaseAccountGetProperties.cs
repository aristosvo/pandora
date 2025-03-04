using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2021_10_15.CosmosDB;


internal class DatabaseAccountGetPropertiesModel
{
    [JsonPropertyName("analyticalStorageConfiguration")]
    public AnalyticalStorageConfigurationModel? AnalyticalStorageConfiguration { get; set; }

    [JsonPropertyName("apiProperties")]
    public ApiPropertiesModel? ApiProperties { get; set; }

    [JsonPropertyName("backupPolicy")]
    public BackupPolicyModel? BackupPolicy { get; set; }

    [JsonPropertyName("capabilities")]
    public List<CapabilityModel>? Capabilities { get; set; }

    [JsonPropertyName("capacity")]
    public CapacityModel? Capacity { get; set; }

    [JsonPropertyName("connectorOffer")]
    public ConnectorOfferConstant? ConnectorOffer { get; set; }

    [JsonPropertyName("consistencyPolicy")]
    public ConsistencyPolicyModel? ConsistencyPolicy { get; set; }

    [JsonPropertyName("cors")]
    public List<CorsPolicyModel>? Cors { get; set; }

    [JsonPropertyName("createMode")]
    public CreateModeConstant? CreateMode { get; set; }

    [JsonPropertyName("databaseAccountOfferType")]
    public DatabaseAccountOfferTypeConstant? DatabaseAccountOfferType { get; set; }

    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    [JsonPropertyName("failoverPolicies")]
    public List<FailoverPolicyModel>? FailoverPolicies { get; set; }

    [JsonPropertyName("ipRules")]
    public List<IPAddressOrRangeModel>? IPRules { get; set; }

    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    [JsonPropertyName("locations")]
    public List<LocationModel>? Locations { get; set; }

    [JsonPropertyName("networkAclBypass")]
    public NetworkAclBypassConstant? NetworkAclBypass { get; set; }

    [JsonPropertyName("networkAclBypassResourceIds")]
    public List<string>? NetworkAclBypassResourceIds { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public List<PrivateEndpointConnectionModel>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public PublicNetworkAccessConstant? PublicNetworkAccess { get; set; }

    [JsonPropertyName("readLocations")]
    public List<LocationModel>? ReadLocations { get; set; }

    [JsonPropertyName("restoreParameters")]
    public RestoreParametersModel? RestoreParameters { get; set; }

    [JsonPropertyName("virtualNetworkRules")]
    public List<VirtualNetworkRuleModel>? VirtualNetworkRules { get; set; }

    [JsonPropertyName("writeLocations")]
    public List<LocationModel>? WriteLocations { get; set; }
}
