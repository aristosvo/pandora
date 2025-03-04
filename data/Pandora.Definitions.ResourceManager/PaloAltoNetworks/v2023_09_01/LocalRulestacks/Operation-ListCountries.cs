using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PaloAltoNetworks.v2023_09_01.LocalRulestacks;

internal class ListCountriesOperation : Pandora.Definitions.Operations.ListOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override Type? RequestObject() => null;

    public override ResourceID? ResourceId() => new LocalRulestackId();

    public override Type NestedItemType() => typeof(CountryModel);

    public override Type? OptionsObject() => typeof(ListCountriesOperation.ListCountriesOptions);

    public override string? UriSuffix() => "/listCountries";

    public override System.Net.Http.HttpMethod Method() => System.Net.Http.HttpMethod.Post;

    internal class ListCountriesOptions
    {
        [QueryStringName("skip")]
        [Optional]
        public string Skip { get; set; }

        [QueryStringName("top")]
        [Optional]
        public int Top { get; set; }
    }
}
