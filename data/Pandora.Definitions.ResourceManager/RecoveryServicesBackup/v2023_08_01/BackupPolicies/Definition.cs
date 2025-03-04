using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_08_01.BackupPolicies;

internal class Definition : ResourceDefinition
{
    public string Name => "BackupPolicies";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(DayOfWeekConstant),
        typeof(IAASVMPolicyTypeConstant),
        typeof(IaasVMSnapshotConsistencyTypeConstant),
        typeof(MonthOfYearConstant),
        typeof(PolicyTypeConstant),
        typeof(RetentionDurationTypeConstant),
        typeof(RetentionScheduleFormatConstant),
        typeof(ScheduleRunTypeConstant),
        typeof(TieringModeConstant),
        typeof(WeekOfMonthConstant),
        typeof(WorkloadTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AzureFileShareProtectionPolicyModel),
        typeof(AzureIaaSVMProtectionPolicyModel),
        typeof(AzureSqlProtectionPolicyModel),
        typeof(AzureVMWorkloadProtectionPolicyModel),
        typeof(DailyRetentionFormatModel),
        typeof(DailyRetentionScheduleModel),
        typeof(DailyScheduleModel),
        typeof(DayModel),
        typeof(GenericProtectionPolicyModel),
        typeof(HourlyScheduleModel),
        typeof(InstantRPAdditionalDetailsModel),
        typeof(LogSchedulePolicyModel),
        typeof(LongTermRetentionPolicyModel),
        typeof(LongTermSchedulePolicyModel),
        typeof(MabProtectionPolicyModel),
        typeof(MonthlyRetentionScheduleModel),
        typeof(ProtectionPolicyModel),
        typeof(ProtectionPolicyResourceModel),
        typeof(RetentionDurationModel),
        typeof(RetentionPolicyModel),
        typeof(SchedulePolicyModel),
        typeof(SettingsModel),
        typeof(SimpleRetentionPolicyModel),
        typeof(SimpleSchedulePolicyModel),
        typeof(SimpleSchedulePolicyV2Model),
        typeof(SnapshotBackupAdditionalDetailsModel),
        typeof(SubProtectionPolicyModel),
        typeof(TieringPolicyModel),
        typeof(UserAssignedIdentityPropertiesModel),
        typeof(UserAssignedManagedIdentityDetailsModel),
        typeof(VaultRetentionPolicyModel),
        typeof(WeeklyRetentionFormatModel),
        typeof(WeeklyRetentionScheduleModel),
        typeof(WeeklyScheduleModel),
        typeof(YearlyRetentionScheduleModel),
    };
}
