using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PaloAltoNetworks.v2022_08_29.LocalRulestacks;

internal class ListCountriesOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => null;

    public override ResourceID? ResourceId() => new LocalRulestackId();

    public override Type? ResponseObject() => typeof(CountriesResponseModel);

    public override Type? OptionsObject() => typeof(ListCountriesOperation.ListCountriesOptions);

    public override string? UriSuffix() => "/listCountries";

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
