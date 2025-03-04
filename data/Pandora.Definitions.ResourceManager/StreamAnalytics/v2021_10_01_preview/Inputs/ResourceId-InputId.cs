using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StreamAnalytics.v2021_10_01_preview.Inputs;

internal class InputId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingJobs/{streamingJobName}/inputs/{inputName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftStreamAnalytics", "Microsoft.StreamAnalytics"),
        ResourceIDSegment.Static("staticStreamingJobs", "streamingJobs"),
        ResourceIDSegment.UserSpecified("streamingJobName"),
        ResourceIDSegment.Static("staticInputs", "inputs"),
        ResourceIDSegment.UserSpecified("inputName"),
    };
}
