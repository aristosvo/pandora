using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2022_08_08.HybridRunbookWorker;

internal class Definition : ResourceDefinition
{
    public string Name => "HybridRunbookWorker";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByHybridRunbookWorkerGroupOperation(),
        new MoveOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(WorkerTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(HybridRunbookWorkerModel),
        typeof(HybridRunbookWorkerCreateOrUpdateParametersModel),
        typeof(HybridRunbookWorkerCreateParametersModel),
        typeof(HybridRunbookWorkerMoveParametersModel),
        typeof(HybridRunbookWorkerPropertiesModel),
    };
}
