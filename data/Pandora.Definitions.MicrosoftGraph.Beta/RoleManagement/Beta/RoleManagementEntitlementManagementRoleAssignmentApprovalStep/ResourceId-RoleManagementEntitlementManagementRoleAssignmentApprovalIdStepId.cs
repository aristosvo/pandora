// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.RoleManagement.Beta.RoleManagementEntitlementManagementRoleAssignmentApprovalStep;

internal class RoleManagementEntitlementManagementRoleAssignmentApprovalIdStepId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/roleManagement/entitlementManagement/roleAssignmentApprovals/{approvalId}/steps/{approvalStepId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticRoleManagement", "roleManagement"),
        ResourceIDSegment.Static("staticEntitlementManagement", "entitlementManagement"),
        ResourceIDSegment.Static("staticRoleAssignmentApprovals", "roleAssignmentApprovals"),
        ResourceIDSegment.UserSpecified("approvalId"),
        ResourceIDSegment.Static("staticSteps", "steps"),
        ResourceIDSegment.UserSpecified("approvalStepId")
    };
}
