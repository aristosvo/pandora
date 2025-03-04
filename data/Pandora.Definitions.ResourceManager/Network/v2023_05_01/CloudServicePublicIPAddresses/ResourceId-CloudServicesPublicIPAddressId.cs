using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_05_01.CloudServicePublicIPAddresses;

internal class CloudServicesPublicIPAddressId : ResourceID
{
    public string? CommonAlias => "CloudServicesPublicIPAddress";

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roleInstances/{roleInstanceName}/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}/publicIPAddresses/{publicIPAddressName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("subscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("resourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("providers", "providers"),
        ResourceIDSegment.ResourceProvider("resourceProvider", "Microsoft.Compute"),
        ResourceIDSegment.Static("cloudServices", "cloudServices"),
        ResourceIDSegment.UserSpecified("cloudServiceName"),
        ResourceIDSegment.Static("roleInstances", "roleInstances"),
        ResourceIDSegment.UserSpecified("roleInstanceName"),
        ResourceIDSegment.Static("networkInterfaces", "networkInterfaces"),
        ResourceIDSegment.UserSpecified("networkInterfaceName"),
        ResourceIDSegment.Static("ipConfigurations", "ipConfigurations"),
        ResourceIDSegment.UserSpecified("ipConfigurationName"),
        ResourceIDSegment.Static("publicIPAddresses", "publicIPAddresses"),
        ResourceIDSegment.UserSpecified("publicIPAddressName"),
    };
}
