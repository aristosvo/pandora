// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeOutlookTaskGroupTaskFolderTask;

internal class MeOutlookTaskGroupIdTaskFolderId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/outlook/taskGroups/{outlookTaskGroupId}/taskFolders/{outlookTaskFolderId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticOutlook", "outlook"),
        ResourceIDSegment.Static("staticTaskGroups", "taskGroups"),
        ResourceIDSegment.UserSpecified("outlookTaskGroupId"),
        ResourceIDSegment.Static("staticTaskFolders", "taskFolders"),
        ResourceIDSegment.UserSpecified("outlookTaskFolderId")
    };
}
