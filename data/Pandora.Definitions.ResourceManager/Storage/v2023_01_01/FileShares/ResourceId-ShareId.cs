using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2023_01_01.FileShares;

internal class ShareId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{storageAccountName}/fileServices/default/shares/{shareName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftStorage", "Microsoft.Storage"),
        ResourceIDSegment.Static("staticStorageAccounts", "storageAccounts"),
        ResourceIDSegment.UserSpecified("storageAccountName"),
        ResourceIDSegment.Static("staticFileServices", "fileServices"),
        ResourceIDSegment.Static("staticDefault", "default"),
        ResourceIDSegment.Static("staticShares", "shares"),
        ResourceIDSegment.UserSpecified("shareName"),
    };
}
