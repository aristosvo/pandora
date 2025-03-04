using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Maintenance.v2023_04_01.ApplyUpdates;

internal class CreateOrUpdateParentOperation : Pandora.Definitions.Operations.PutOperation
{
    public override Type? RequestObject() => null;

    public override ResourceID? ResourceId() => new ScopeId();

    public override Type? ResponseObject() => typeof(ApplyUpdateModel);

    public override string? UriSuffix() => "/providers/Microsoft.Maintenance/applyUpdates/default";


}
