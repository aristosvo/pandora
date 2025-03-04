using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RedHatOpenShift.v2023_09_04.Secrets;

internal class SecretId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RedHatOpenShift/openShiftClusters/{openShiftClusterName}/secret/{secretName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftRedHatOpenShift", "Microsoft.RedHatOpenShift"),
        ResourceIDSegment.Static("staticOpenShiftClusters", "openShiftClusters"),
        ResourceIDSegment.UserSpecified("openShiftClusterName"),
        ResourceIDSegment.Static("staticSecret", "secret"),
        ResourceIDSegment.UserSpecified("secretName"),
    };
}
