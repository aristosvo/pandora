using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.WebApps;

internal class SlotWorkflowId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName}/workflows/{workflowName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftWeb", "Microsoft.Web"),
        ResourceIDSegment.Static("staticSites", "sites"),
        ResourceIDSegment.UserSpecified("siteName"),
        ResourceIDSegment.Static("staticSlots", "slots"),
        ResourceIDSegment.UserSpecified("slotName"),
        ResourceIDSegment.Static("staticWorkflows", "workflows"),
        ResourceIDSegment.UserSpecified("workflowName"),
    };
}
