// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeOnenoteNotebookSectionPage;

internal class CreateMeOnenoteNotebookByIdSectionByIdPageOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(OnenotePageModel);
    public override ResourceID? ResourceId() => new MeOnenoteNotebookIdSectionId();
    public override Type? ResponseObject() => typeof(OnenotePageModel);
    public override string? UriSuffix() => "/pages";
}
