// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeCalendarGroupCalendarEventExceptionOccurrenceInstanceAttachment;

internal class DeleteMeCalendarGroupByIdCalendarByIdEventByIdExceptionOccurrenceByIdInstanceByIdAttachmentByIdOperation : Operations.DeleteOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.NoContent,
        };
    public override ResourceID? ResourceId() => new MeCalendarGroupIdCalendarIdEventIdExceptionOccurrenceIdInstanceIdAttachmentId();
    public override string? UriSuffix() => null;
}
