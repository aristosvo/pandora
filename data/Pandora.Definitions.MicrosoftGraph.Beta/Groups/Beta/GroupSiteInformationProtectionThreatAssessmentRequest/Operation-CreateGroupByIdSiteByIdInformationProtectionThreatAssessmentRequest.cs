// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupSiteInformationProtectionThreatAssessmentRequest;

internal class CreateGroupByIdSiteByIdInformationProtectionThreatAssessmentRequestOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(ThreatAssessmentRequestModel);
    public override ResourceID? ResourceId() => new GroupIdSiteId();
    public override Type? ResponseObject() => typeof(ThreatAssessmentRequestModel);
    public override string? UriSuffix() => "/informationProtection/threatAssessmentRequests";
}
