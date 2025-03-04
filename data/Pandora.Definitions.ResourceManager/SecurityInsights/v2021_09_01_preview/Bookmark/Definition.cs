using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2021_09_01_preview.Bookmark;

internal class Definition : ResourceDefinition
{
    public string Name => "Bookmark";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ExpandOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(EntityKindConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(BookmarkExpandParametersModel),
        typeof(BookmarkExpandResponseModel),
        typeof(BookmarkExpandResponseValueModel),
        typeof(ConnectedEntityModel),
        typeof(EntityModel),
        typeof(ExpansionResultAggregationModel),
        typeof(ExpansionResultsMetadataModel),
    };
}
