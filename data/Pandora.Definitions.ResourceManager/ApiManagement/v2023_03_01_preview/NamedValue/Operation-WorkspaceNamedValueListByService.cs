using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.NamedValue;

internal class WorkspaceNamedValueListByServiceOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new WorkspaceId();

    public override Type NestedItemType() => typeof(NamedValueContractModel);

    public override Type? OptionsObject() => typeof(WorkspaceNamedValueListByServiceOperation.WorkspaceNamedValueListByServiceOptions);

    public override string? UriSuffix() => "/namedValues";

    internal class WorkspaceNamedValueListByServiceOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("isKeyVaultRefreshFailed")]
        [Optional]
        public KeyVaultRefreshStateConstant IsKeyVaultRefreshFailed { get; set; }

        [QueryStringName("$skip")]
        [Optional]
        public int Skip { get; set; }

        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
