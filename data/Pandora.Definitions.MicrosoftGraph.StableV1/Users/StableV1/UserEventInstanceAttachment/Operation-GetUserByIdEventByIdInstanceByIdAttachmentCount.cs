// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserEventInstanceAttachment;

internal class GetUserByIdEventByIdInstanceByIdAttachmentCountOperation : Operations.GetOperation
{
    public override string? ContentType() => "text/plain";
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override ResourceID? ResourceId() => new UserIdEventIdInstanceId();
    public override Type? ResponseObject() => null;
    public override string? UriSuffix() => "/attachments/$count";
}
