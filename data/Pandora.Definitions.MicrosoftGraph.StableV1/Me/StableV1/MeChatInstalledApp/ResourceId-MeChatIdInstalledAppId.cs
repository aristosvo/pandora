// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeChatInstalledApp;

internal class MeChatIdInstalledAppId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/chats/{chatId}/installedApps/{teamsAppInstallationId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticChats", "chats"),
        ResourceIDSegment.UserSpecified("chatId"),
        ResourceIDSegment.Static("staticInstalledApps", "installedApps"),
        ResourceIDSegment.UserSpecified("teamsAppInstallationId")
    };
}
