using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_08_01.ResourceGuardProxy;

internal class UnlockDeleteOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(UnlockDeleteRequestModel);

    public override ResourceID? ResourceId() => new BackupResourceGuardProxyId();

    public override Type? ResponseObject() => typeof(UnlockDeleteResponseModel);

    public override string? UriSuffix() => "/unlockDelete";


}
