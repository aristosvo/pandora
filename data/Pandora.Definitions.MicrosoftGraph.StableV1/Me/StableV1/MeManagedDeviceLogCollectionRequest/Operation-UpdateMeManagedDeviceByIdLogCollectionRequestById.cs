// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeManagedDeviceLogCollectionRequest;

internal class UpdateMeManagedDeviceByIdLogCollectionRequestByIdOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(DeviceLogCollectionResponseModel);
    public override ResourceID? ResourceId() => new MeManagedDeviceIdLogCollectionRequestId();
    public override Type? ResponseObject() => typeof(DeviceLogCollectionResponseModel);
    public override string? UriSuffix() => null;
}
