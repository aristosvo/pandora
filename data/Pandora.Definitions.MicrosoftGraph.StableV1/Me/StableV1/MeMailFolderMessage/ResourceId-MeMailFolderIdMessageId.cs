// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeMailFolderMessage;

internal class MeMailFolderIdMessageId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/mailFolders/{mailFolderId}/messages/{messageId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticMailFolders", "mailFolders"),
        ResourceIDSegment.UserSpecified("mailFolderId"),
        ResourceIDSegment.Static("staticMessages", "messages"),
        ResourceIDSegment.UserSpecified("messageId")
    };
}
