using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_08_01.BackupPolicies;


internal class SubProtectionPolicyModel
{
    [JsonPropertyName("policyType")]
    public PolicyTypeConstant? PolicyType { get; set; }

    [JsonPropertyName("retentionPolicy")]
    public RetentionPolicyModel? RetentionPolicy { get; set; }

    [JsonPropertyName("schedulePolicy")]
    public SchedulePolicyModel? SchedulePolicy { get; set; }

    [JsonPropertyName("snapshotBackupAdditionalDetails")]
    public SnapshotBackupAdditionalDetailsModel? SnapshotBackupAdditionalDetails { get; set; }

    [JsonPropertyName("tieringPolicy")]
    public Dictionary<string, TieringPolicyModel>? TieringPolicy { get; set; }
}
