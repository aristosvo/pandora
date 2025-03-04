using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2023_04_02.IncrementalRestorePoints;

internal class DiskRestorePointId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}/diskRestorePoints/{diskRestorePointName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftCompute", "Microsoft.Compute"),
        ResourceIDSegment.Static("staticRestorePointCollections", "restorePointCollections"),
        ResourceIDSegment.UserSpecified("restorePointCollectionName"),
        ResourceIDSegment.Static("staticRestorePoints", "restorePoints"),
        ResourceIDSegment.UserSpecified("restorePointName"),
        ResourceIDSegment.Static("staticDiskRestorePoints", "diskRestorePoints"),
        ResourceIDSegment.UserSpecified("diskRestorePointName"),
    };
}
