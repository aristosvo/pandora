using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PolicyInsights.v2021_10_01.Remediations;

internal class ListDeploymentsAtSubscriptionOperation : Pandora.Definitions.Operations.ListOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override Type? RequestObject() => null;

    public override ResourceID? ResourceId() => new RemediationId();

    public override Type NestedItemType() => typeof(RemediationDeploymentModel);

    public override Type? OptionsObject() => typeof(ListDeploymentsAtSubscriptionOperation.ListDeploymentsAtSubscriptionOptions);

    public override string? UriSuffix() => "/listDeployments";

    public override System.Net.Http.HttpMethod Method() => System.Net.Http.HttpMethod.Post;

    internal class ListDeploymentsAtSubscriptionOptions
    {
        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
