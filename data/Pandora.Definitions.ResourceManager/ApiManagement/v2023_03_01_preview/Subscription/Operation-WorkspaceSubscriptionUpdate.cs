using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.Subscription;

internal class WorkspaceSubscriptionUpdateOperation : Pandora.Definitions.Operations.PatchOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(SubscriptionUpdateParametersModel);

    public override ResourceID? ResourceId() => new WorkspaceSubscriptions2Id();

    public override Type? ResponseObject() => typeof(SubscriptionContractModel);

    public override Type? OptionsObject() => typeof(WorkspaceSubscriptionUpdateOperation.WorkspaceSubscriptionUpdateOptions);

    internal class WorkspaceSubscriptionUpdateOptions
    {
        [QueryStringName("appType")]
        [Optional]
        public AppTypeConstant AppType { get; set; }

        [HeaderName("If-Match")]
        public string IfMatch { get; set; }

        [QueryStringName("notify")]
        [Optional]
        public bool Notify { get; set; }
    }
}
