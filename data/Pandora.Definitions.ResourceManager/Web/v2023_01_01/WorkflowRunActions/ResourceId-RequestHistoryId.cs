using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.WorkflowRunActions;

internal class RequestHistoryId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/hostRuntime/runtime/webHooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}";

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
        ResourceIDSegment.Static("staticHostRuntime", "hostRuntime"),
        ResourceIDSegment.Static("staticRuntime", "runtime"),
        ResourceIDSegment.Static("staticWebHooks", "webHooks"),
        ResourceIDSegment.Static("staticWorkflow", "workflow"),
        ResourceIDSegment.Static("staticApi", "api"),
        ResourceIDSegment.Static("staticManagement", "management"),
        ResourceIDSegment.Static("staticWorkflows", "workflows"),
        ResourceIDSegment.UserSpecified("workflowName"),
        ResourceIDSegment.Static("staticRuns", "runs"),
        ResourceIDSegment.UserSpecified("runName"),
        ResourceIDSegment.Static("staticActions", "actions"),
        ResourceIDSegment.UserSpecified("actionName"),
        ResourceIDSegment.Static("staticRepetitions", "repetitions"),
        ResourceIDSegment.UserSpecified("repetitionName"),
        ResourceIDSegment.Static("staticRequestHistories", "requestHistories"),
        ResourceIDSegment.UserSpecified("requestHistoryName"),
    };
}
