// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserTodoListTaskChecklistItem;

internal class UpdateUserByIdTodoListByIdTaskByIdChecklistItemByIdOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(ChecklistItemModel);
    public override ResourceID? ResourceId() => new UserIdTodoListIdTaskIdChecklistItemId();
    public override Type? ResponseObject() => typeof(ChecklistItemModel);
    public override string? UriSuffix() => null;
}
