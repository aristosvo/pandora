// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupOnenoteNotebookSectionParentNotebook;

internal class GetGroupByIdOnenoteNotebookByIdSectionByIdParentNotebookOperation : Operations.GetOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override ResourceID? ResourceId() => new GroupIdOnenoteNotebookIdSectionId();
    public override Type? ResponseObject() => typeof(NotebookModel);
    public override string? UriSuffix() => "/parentNotebook";
}
