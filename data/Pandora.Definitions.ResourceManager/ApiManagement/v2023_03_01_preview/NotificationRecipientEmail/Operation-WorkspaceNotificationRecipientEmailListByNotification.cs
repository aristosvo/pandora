using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.NotificationRecipientEmail;

internal class WorkspaceNotificationRecipientEmailListByNotificationOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new NotificationNotificationId();

    public override Type? ResponseObject() => typeof(RecipientEmailCollectionModel);

    public override string? UriSuffix() => "/recipientEmails";


}
