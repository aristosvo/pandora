// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.RoleManagement.Beta.RoleManagementEntitlementManagementRoleAssignmentScheduleRequestAppScope;

internal class GetRoleManagementEntitlementManagementRoleAssignmentScheduleRequestByIdAppScopeOperation : Operations.GetOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override ResourceID? ResourceId() => new RoleManagementEntitlementManagementRoleAssignmentScheduleRequestId();
    public override Type? ResponseObject() => typeof(AppScopeModel);
    public override string? UriSuffix() => "/appScope";
}
