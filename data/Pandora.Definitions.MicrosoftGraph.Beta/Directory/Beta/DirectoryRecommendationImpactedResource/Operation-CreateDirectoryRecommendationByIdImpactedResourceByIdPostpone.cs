// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Directory.Beta.DirectoryRecommendationImpactedResource;

internal class CreateDirectoryRecommendationByIdImpactedResourceByIdPostponeOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(CreateDirectoryRecommendationByIdImpactedResourceByIdPostponeRequestModel);
    public override ResourceID? ResourceId() => new DirectoryRecommendationIdImpactedResourceId();
    public override Type? ResponseObject() => typeof(ImpactedResourceModel);
    public override string? UriSuffix() => "/postpone";
}
