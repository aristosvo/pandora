using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataMigration.v2021_06_30.StandardOperation;

internal class TasksDeleteOperation : Pandora.Definitions.Operations.DeleteOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.NoContent,
                HttpStatusCode.OK,
        };

    public override ResourceID? ResourceId() => new TaskId();

    public override Type? OptionsObject() => typeof(TasksDeleteOperation.TasksDeleteOptions);

    internal class TasksDeleteOptions
    {
        [QueryStringName("deleteRunningTasks")]
        [Optional]
        public bool DeleteRunningTasks { get; set; }
    }
}
