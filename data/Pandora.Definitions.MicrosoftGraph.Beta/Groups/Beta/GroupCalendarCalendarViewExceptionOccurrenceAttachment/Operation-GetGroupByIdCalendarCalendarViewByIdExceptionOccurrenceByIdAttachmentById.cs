// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupCalendarCalendarViewExceptionOccurrenceAttachment;

internal class GetGroupByIdCalendarCalendarViewByIdExceptionOccurrenceByIdAttachmentByIdOperation : Operations.GetOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override ResourceID? ResourceId() => new GroupIdCalendarCalendarViewIdExceptionOccurrenceIdAttachmentId();
    public override Type? ResponseObject() => typeof(AttachmentModel);
    public override string? UriSuffix() => null;
}
