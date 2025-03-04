using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.LongTermRetentionManagedInstanceBackups;

internal class ListByResourceGroupDatabaseOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new LongTermRetentionManagedInstanceLongTermRetentionDatabaseId();

    public override Type NestedItemType() => typeof(ManagedInstanceLongTermRetentionBackupModel);

    public override Type? OptionsObject() => typeof(ListByResourceGroupDatabaseOperation.ListByResourceGroupDatabaseOptions);

    public override string? UriSuffix() => "/longTermRetentionManagedInstanceBackups";

    internal class ListByResourceGroupDatabaseOptions
    {
        [QueryStringName("databaseState")]
        [Optional]
        public DatabaseStateConstant DatabaseState { get; set; }

        [QueryStringName("onlyLatestPerDatabase")]
        [Optional]
        public bool OnlyLatestPerDatabase { get; set; }
    }
}
