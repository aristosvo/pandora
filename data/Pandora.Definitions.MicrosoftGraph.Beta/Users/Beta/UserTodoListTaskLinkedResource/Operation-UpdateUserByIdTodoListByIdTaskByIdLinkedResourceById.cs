// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserTodoListTaskLinkedResource;

internal class UpdateUserByIdTodoListByIdTaskByIdLinkedResourceByIdOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(LinkedResourceModel);
    public override ResourceID? ResourceId() => new UserIdTodoListIdTaskIdLinkedResourceId();
    public override Type? ResponseObject() => typeof(LinkedResourceModel);
    public override string? UriSuffix() => null;
}
