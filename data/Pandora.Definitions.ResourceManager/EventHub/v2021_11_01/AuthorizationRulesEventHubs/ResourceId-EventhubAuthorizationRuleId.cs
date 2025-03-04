using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.EventHub.v2021_11_01.AuthorizationRulesEventHubs;

internal class EventhubAuthorizationRuleId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventhubName}/authorizationRules/{authorizationRuleName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftEventHub", "Microsoft.EventHub"),
        ResourceIDSegment.Static("staticNamespaces", "namespaces"),
        ResourceIDSegment.UserSpecified("namespaceName"),
        ResourceIDSegment.Static("staticEventhubs", "eventhubs"),
        ResourceIDSegment.UserSpecified("eventhubName"),
        ResourceIDSegment.Static("staticAuthorizationRules", "authorizationRules"),
        ResourceIDSegment.UserSpecified("authorizationRuleName"),
    };
}
