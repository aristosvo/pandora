// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserPlannerPlanBucketTask;

internal class Definition : ResourceDefinition
{
    public string Name => "UserPlannerPlanBucketTask";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUserByIdPlannerPlanByIdBucketByIdTaskOperation(),
        new DeleteUserByIdPlannerPlanByIdBucketByIdTaskByIdOperation(),
        new GetUserByIdPlannerPlanByIdBucketByIdTaskByIdOperation(),
        new GetUserByIdPlannerPlanByIdBucketByIdTaskCountOperation(),
        new ListUserByIdPlannerPlanByIdBucketByIdTasksOperation(),
        new UpdateUserByIdPlannerPlanByIdBucketByIdTaskByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
