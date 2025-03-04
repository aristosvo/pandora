using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SystemCenterVirtualMachineManager.v2023_10_07.VirtualMachineTemplates;


internal class NetworkInterfaceModel
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("ipv4AddressType")]
    public AllocationMethodConstant? IPv4AddressType { get; set; }

    [JsonPropertyName("ipv4Addresses")]
    public List<string>? IPv4Addresses { get; set; }

    [JsonPropertyName("ipv6AddressType")]
    public AllocationMethodConstant? IPv6AddressType { get; set; }

    [JsonPropertyName("ipv6Addresses")]
    public List<string>? IPv6Addresses { get; set; }

    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    [JsonPropertyName("macAddressType")]
    public AllocationMethodConstant? MacAddressType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("nicId")]
    public string? NicId { get; set; }

    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}
