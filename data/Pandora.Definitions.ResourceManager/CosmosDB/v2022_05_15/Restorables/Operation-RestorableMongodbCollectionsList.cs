using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2022_05_15.Restorables;

internal class RestorableMongodbCollectionsListOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new RestorableDatabaseAccountId();

    public override Type? ResponseObject() => typeof(RestorableMongodbCollectionsListResultModel);

    public override Type? OptionsObject() => typeof(RestorableMongodbCollectionsListOperation.RestorableMongodbCollectionsListOptions);

    public override string? UriSuffix() => "/restorableMongodbCollections";

    internal class RestorableMongodbCollectionsListOptions
    {
        [QueryStringName("restorableMongodbDatabaseRid")]
        [Optional]
        public string RestorableMongodbDatabaseRid { get; set; }
    }
}
