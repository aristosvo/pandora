using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2022_09_09.MsixImage;

internal class ExpandOperation : Pandora.Definitions.Operations.ListOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override Type? RequestObject() => typeof(MSIXImageURIModel);

    public override ResourceID? ResourceId() => new HostPoolId();

    public override Type NestedItemType() => typeof(ExpandMsixImageModel);

    public override string? UriSuffix() => "/expandMsixImage";

    public override System.Net.Http.HttpMethod Method() => System.Net.Http.HttpMethod.Post;


}
