using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PaloAltoNetworks.v2023_09_01.PostRules;

internal class GetCountersOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => null;

    public override ResourceID? ResourceId() => new PostRuleId();

    public override Type? ResponseObject() => typeof(RuleCounterModel);

    public override Type? OptionsObject() => typeof(GetCountersOperation.GetCountersOptions);

    public override string? UriSuffix() => "/getCounters";

    internal class GetCountersOptions
    {
        [QueryStringName("firewallName")]
        [Optional]
        public string FirewallName { get; set; }
    }
}
