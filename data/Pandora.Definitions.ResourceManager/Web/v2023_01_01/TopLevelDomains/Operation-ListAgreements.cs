using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.TopLevelDomains;

internal class ListAgreementsOperation : Pandora.Definitions.Operations.ListOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override Type? RequestObject() => typeof(TopLevelDomainAgreementOptionModel);

    public override ResourceID? ResourceId() => new TopLevelDomainId();

    public override Type NestedItemType() => typeof(TldLegalAgreementModel);

    public override string? UriSuffix() => "/listAgreements";

    public override System.Net.Http.HttpMethod Method() => System.Net.Http.HttpMethod.Post;


}
