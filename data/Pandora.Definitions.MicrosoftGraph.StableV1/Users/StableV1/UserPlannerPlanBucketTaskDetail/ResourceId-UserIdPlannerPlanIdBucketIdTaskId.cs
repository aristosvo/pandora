// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserPlannerPlanBucketTaskDetail;

internal class UserIdPlannerPlanIdBucketIdTaskId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/planner/plans/{plannerPlanId}/buckets/{plannerBucketId}/tasks/{plannerTaskId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticPlanner", "planner"),
        ResourceIDSegment.Static("staticPlans", "plans"),
        ResourceIDSegment.UserSpecified("plannerPlanId"),
        ResourceIDSegment.Static("staticBuckets", "buckets"),
        ResourceIDSegment.UserSpecified("plannerBucketId"),
        ResourceIDSegment.Static("staticTasks", "tasks"),
        ResourceIDSegment.UserSpecified("plannerTaskId")
    };
}
