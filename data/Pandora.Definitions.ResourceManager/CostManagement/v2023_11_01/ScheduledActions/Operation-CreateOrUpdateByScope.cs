using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_11_01.ScheduledActions;

internal class CreateOrUpdateByScopeOperation : Pandora.Definitions.Operations.PutOperation
{
    public override Type? RequestObject() => typeof(ScheduledActionModel);

    public override ResourceID? ResourceId() => new ScopedScheduledActionId();

    public override Type? ResponseObject() => typeof(ScheduledActionModel);

    public override Type? OptionsObject() => typeof(CreateOrUpdateByScopeOperation.CreateOrUpdateByScopeOptions);

    internal class CreateOrUpdateByScopeOptions
    {
        [HeaderName("If-Match")]
        [Optional]
        public string IfMatch { get; set; }
    }
}
