// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class IdentityGovernanceWorkflowModel
{
    [JsonPropertyName("category")]
    public IdentityGovernanceWorkflowCategoryConstant? Category { get; set; }

    [JsonPropertyName("createdBy")]
    public UserModel? CreatedBy { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("deletedDateTime")]
    public DateTime? DeletedDateTime { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("executionConditions")]
    public IdentityGovernanceWorkflowExecutionConditionsModel? ExecutionConditions { get; set; }

    [JsonPropertyName("executionScope")]
    public List<IdentityGovernanceUserProcessingResultModel>? ExecutionScope { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("isSchedulingEnabled")]
    public bool? IsSchedulingEnabled { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public UserModel? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("nextScheduleRunDateTime")]
    public DateTime? NextScheduleRunDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("runs")]
    public List<IdentityGovernanceRunModel>? Runs { get; set; }

    [JsonPropertyName("taskReports")]
    public List<IdentityGovernanceTaskReportModel>? TaskReports { get; set; }

    [JsonPropertyName("tasks")]
    public List<IdentityGovernanceTaskModel>? Tasks { get; set; }

    [JsonPropertyName("userProcessingResults")]
    public List<IdentityGovernanceUserProcessingResultModel>? UserProcessingResults { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }

    [JsonPropertyName("versions")]
    public List<IdentityGovernanceWorkflowVersionModel>? Versions { get; set; }
}
