// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupSiteContentTypeColumn;

internal class GetGroupByIdSiteByIdContentTypeByIdColumnCountOperation : Operations.GetOperation
{
    public override string? ContentType() => "text/plain";
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override ResourceID? ResourceId() => new GroupIdSiteIdContentTypeId();
    public override Type? ResponseObject() => null;
    public override string? UriSuffix() => "/columns/$count";
}
