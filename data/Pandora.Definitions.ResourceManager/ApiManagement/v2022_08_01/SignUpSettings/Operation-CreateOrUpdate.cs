using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.SignUpSettings;

internal class CreateOrUpdateOperation : Pandora.Definitions.Operations.PutOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(PortalSignupSettingsModel);

    public override ResourceID? ResourceId() => new ServiceId();

    public override Type? ResponseObject() => typeof(PortalSignupSettingsModel);

    public override Type? OptionsObject() => typeof(CreateOrUpdateOperation.CreateOrUpdateOptions);

    public override string? UriSuffix() => "/portalsettings/signup";

    internal class CreateOrUpdateOptions
    {
        [HeaderName("If-Match")]
        [Optional]
        public string IfMatch { get; set; }
    }
}
