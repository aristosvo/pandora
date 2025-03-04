// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeOutlookTaskFolderTaskAttachment;

internal class MeOutlookTaskFolderIdTaskIdAttachmentId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/outlook/taskFolders/{outlookTaskFolderId}/tasks/{outlookTaskId}/attachments/{attachmentId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticOutlook", "outlook"),
        ResourceIDSegment.Static("staticTaskFolders", "taskFolders"),
        ResourceIDSegment.UserSpecified("outlookTaskFolderId"),
        ResourceIDSegment.Static("staticTasks", "tasks"),
        ResourceIDSegment.UserSpecified("outlookTaskId"),
        ResourceIDSegment.Static("staticAttachments", "attachments"),
        ResourceIDSegment.UserSpecified("attachmentId")
    };
}
