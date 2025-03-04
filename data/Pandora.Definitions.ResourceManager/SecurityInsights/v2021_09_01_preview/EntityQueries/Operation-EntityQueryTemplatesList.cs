using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2021_09_01_preview.EntityQueries;

internal class EntityQueryTemplatesListOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new WorkspaceId();

    public override Type NestedItemType() => typeof(EntityQueryTemplateModel);

    public override Type? OptionsObject() => typeof(EntityQueryTemplatesListOperation.EntityQueryTemplatesListOptions);

    public override string? UriSuffix() => "/providers/Microsoft.SecurityInsights/entityQueryTemplates";

    internal class EntityQueryTemplatesListOptions
    {
        [QueryStringName("kind")]
        [Optional]
        public KindConstant Kind { get; set; }
    }
}
