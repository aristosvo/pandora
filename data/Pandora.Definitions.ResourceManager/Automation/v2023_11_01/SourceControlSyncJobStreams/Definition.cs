using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2023_11_01.SourceControlSyncJobStreams;

internal class Definition : ResourceDefinition
{
    public string Name => "SourceControlSyncJobStreams";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new ListBySyncJobOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(StreamTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(SourceControlSyncJobStreamModel),
        typeof(SourceControlSyncJobStreamByIdModel),
        typeof(SourceControlSyncJobStreamByIdPropertiesModel),
        typeof(SourceControlSyncJobStreamPropertiesModel),
    };
}
