// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupSiteTermStoreSetChildrenChildrenRelation;

internal class UpdateGroupByIdSiteByIdTermStoreByIdSetByIdChildrenByIdChildrenByIdRelationByIdOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(TermStoreRelationModel);
    public override ResourceID? ResourceId() => new GroupIdSiteIdTermStoreIdSetIdChildrenIdChildrenIdRelationId();
    public override Type? ResponseObject() => typeof(TermStoreRelationModel);
    public override string? UriSuffix() => null;
}
