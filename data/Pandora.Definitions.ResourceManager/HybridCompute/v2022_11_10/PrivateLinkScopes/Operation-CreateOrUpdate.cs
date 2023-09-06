using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HybridCompute.v2022_11_10.PrivateLinkScopes;

internal class CreateOrUpdateOperation : Pandora.Definitions.Operations.PutOperation
{
    public override Type? RequestObject() => typeof(HybridComputePrivateLinkScopeModel);

    public override ResourceID? ResourceId() => new ProviderPrivateLinkScopeId();

    public override Type? ResponseObject() => typeof(HybridComputePrivateLinkScopeModel);


}
