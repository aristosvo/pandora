// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeContactFolderChildFolderContactPhoto;

internal class GetMeContactFolderByIdChildFolderByIdContactByIdPhotoValueOperation : Operations.GetOperation
{
    public override string? ContentType() => "application/octet-stream";
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override ResourceID? ResourceId() => new MeContactFolderIdChildFolderIdContactId();
    public override Type? ResponseObject() => typeof(RawFile);
    public override string? UriSuffix() => "/photo/$value";
}
