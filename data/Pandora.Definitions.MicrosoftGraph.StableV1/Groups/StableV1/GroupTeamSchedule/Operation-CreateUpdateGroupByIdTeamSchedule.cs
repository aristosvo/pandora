// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupTeamSchedule;

internal class CreateUpdateGroupByIdTeamScheduleOperation : Operations.PutOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(ScheduleModel);
    public override ResourceID? ResourceId() => new GroupId();
    public override Type? ResponseObject() => typeof(ScheduleModel);
    public override string? UriSuffix() => "/team/schedule";
}
