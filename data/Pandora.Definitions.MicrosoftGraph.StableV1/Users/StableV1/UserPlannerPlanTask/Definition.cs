// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserPlannerPlanTask;

internal class Definition : ResourceDefinition
{
    public string Name => "UserPlannerPlanTask";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUserByIdPlannerPlanByIdTaskOperation(),
        new DeleteUserByIdPlannerPlanByIdTaskByIdOperation(),
        new GetUserByIdPlannerPlanByIdTaskByIdOperation(),
        new GetUserByIdPlannerPlanByIdTaskCountOperation(),
        new ListUserByIdPlannerPlanByIdTasksOperation(),
        new UpdateUserByIdPlannerPlanByIdTaskByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
