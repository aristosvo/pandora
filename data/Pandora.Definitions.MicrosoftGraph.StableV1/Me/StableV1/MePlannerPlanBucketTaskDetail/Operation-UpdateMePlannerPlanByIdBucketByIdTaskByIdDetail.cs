// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MePlannerPlanBucketTaskDetail;

internal class UpdateMePlannerPlanByIdBucketByIdTaskByIdDetailOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(PlannerTaskDetailsModel);
    public override ResourceID? ResourceId() => new MePlannerPlanIdBucketIdTaskId();
    public override Type? ResponseObject() => typeof(PlannerTaskDetailsModel);
    public override string? UriSuffix() => "/details";
}
