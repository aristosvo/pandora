// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeMailFolderMessage;

internal class CreateMeMailFolderByIdMessageByIdCreateReplyOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(CreateMeMailFolderByIdMessageByIdCreateReplyRequestModel);
    public override ResourceID? ResourceId() => new MeMailFolderIdMessageId();
    public override Type? ResponseObject() => typeof(MessageModel);
    public override string? UriSuffix() => "/createReply";
}
