/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IdentityManagement
{

    /// <summary>
    /// Constants used for properties of type AssignmentStatusType.
    /// </summary>
    public class AssignmentStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Any for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Any = new AssignmentStatusType("Any");
        /// <summary>
        /// Constant Assigned for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Assigned = new AssignmentStatusType("Assigned");
        /// <summary>
        /// Constant Unassigned for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Unassigned = new AssignmentStatusType("Unassigned");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AssignmentStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignmentStatusType FindValue(string value)
        {
            return FindValue<AssignmentStatusType>(value);
        }

        public static implicit operator AssignmentStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContextKeyTypeEnum.
    /// </summary>
    public class ContextKeyTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Binary for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Binary = new ContextKeyTypeEnum("binary");
        /// <summary>
        /// Constant BinaryList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum BinaryList = new ContextKeyTypeEnum("binaryList");
        /// <summary>
        /// Constant Boolean for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Boolean = new ContextKeyTypeEnum("boolean");
        /// <summary>
        /// Constant BooleanList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum BooleanList = new ContextKeyTypeEnum("booleanList");
        /// <summary>
        /// Constant Date for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Date = new ContextKeyTypeEnum("date");
        /// <summary>
        /// Constant DateList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum DateList = new ContextKeyTypeEnum("dateList");
        /// <summary>
        /// Constant Ip for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Ip = new ContextKeyTypeEnum("ip");
        /// <summary>
        /// Constant IpList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum IpList = new ContextKeyTypeEnum("ipList");
        /// <summary>
        /// Constant Numeric for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Numeric = new ContextKeyTypeEnum("numeric");
        /// <summary>
        /// Constant NumericList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum NumericList = new ContextKeyTypeEnum("numericList");
        /// <summary>
        /// Constant String for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum String = new ContextKeyTypeEnum("string");
        /// <summary>
        /// Constant StringList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum StringList = new ContextKeyTypeEnum("stringList");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ContextKeyTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContextKeyTypeEnum FindValue(string value)
        {
            return FindValue<ContextKeyTypeEnum>(value);
        }

        public static implicit operator ContextKeyTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncodingType.
    /// </summary>
    public class EncodingType : ConstantClass
    {

        /// <summary>
        /// Constant PEM for EncodingType
        /// </summary>
        public static readonly EncodingType PEM = new EncodingType("PEM");
        /// <summary>
        /// Constant SSH for EncodingType
        /// </summary>
        public static readonly EncodingType SSH = new EncodingType("SSH");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EncodingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodingType FindValue(string value)
        {
            return FindValue<EncodingType>(value);
        }

        public static implicit operator EncodingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant AWSManagedPolicy for EntityType
        /// </summary>
        public static readonly EntityType AWSManagedPolicy = new EntityType("AWSManagedPolicy");
        /// <summary>
        /// Constant Group for EntityType
        /// </summary>
        public static readonly EntityType Group = new EntityType("Group");
        /// <summary>
        /// Constant LocalManagedPolicy for EntityType
        /// </summary>
        public static readonly EntityType LocalManagedPolicy = new EntityType("LocalManagedPolicy");
        /// <summary>
        /// Constant Role for EntityType
        /// </summary>
        public static readonly EntityType Role = new EntityType("Role");
        /// <summary>
        /// Constant User for EntityType
        /// </summary>
        public static readonly EntityType User = new EntityType("User");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyEvaluationDecisionType.
    /// </summary>
    public class PolicyEvaluationDecisionType : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for PolicyEvaluationDecisionType
        /// </summary>
        public static readonly PolicyEvaluationDecisionType Allowed = new PolicyEvaluationDecisionType("allowed");
        /// <summary>
        /// Constant ExplicitDeny for PolicyEvaluationDecisionType
        /// </summary>
        public static readonly PolicyEvaluationDecisionType ExplicitDeny = new PolicyEvaluationDecisionType("explicitDeny");
        /// <summary>
        /// Constant ImplicitDeny for PolicyEvaluationDecisionType
        /// </summary>
        public static readonly PolicyEvaluationDecisionType ImplicitDeny = new PolicyEvaluationDecisionType("implicitDeny");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PolicyEvaluationDecisionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyEvaluationDecisionType FindValue(string value)
        {
            return FindValue<PolicyEvaluationDecisionType>(value);
        }

        public static implicit operator PolicyEvaluationDecisionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyScopeType.
    /// </summary>
    public class PolicyScopeType : ConstantClass
    {

        /// <summary>
        /// Constant All for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType All = new PolicyScopeType("All");
        /// <summary>
        /// Constant AWS for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType AWS = new PolicyScopeType("AWS");
        /// <summary>
        /// Constant Local for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType Local = new PolicyScopeType("Local");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PolicyScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyScopeType FindValue(string value)
        {
            return FindValue<PolicyScopeType>(value);
        }

        public static implicit operator PolicyScopeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicySourceType.
    /// </summary>
    public class PolicySourceType : ConstantClass
    {

        /// <summary>
        /// Constant AwsManaged for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType AwsManaged = new PolicySourceType("aws-managed");
        /// <summary>
        /// Constant Group for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType Group = new PolicySourceType("group");
        /// <summary>
        /// Constant None for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType None = new PolicySourceType("none");
        /// <summary>
        /// Constant Resource for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType Resource = new PolicySourceType("resource");
        /// <summary>
        /// Constant Role for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType Role = new PolicySourceType("role");
        /// <summary>
        /// Constant User for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType User = new PolicySourceType("user");
        /// <summary>
        /// Constant UserManaged for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType UserManaged = new PolicySourceType("user-managed");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PolicySourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicySourceType FindValue(string value)
        {
            return FindValue<PolicySourceType>(value);
        }

        public static implicit operator PolicySourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFormatType.
    /// </summary>
    public class ReportFormatType : ConstantClass
    {

        /// <summary>
        /// Constant TextCsv for ReportFormatType
        /// </summary>
        public static readonly ReportFormatType TextCsv = new ReportFormatType("text/csv");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ReportFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFormatType FindValue(string value)
        {
            return FindValue<ReportFormatType>(value);
        }

        public static implicit operator ReportFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportStateType.
    /// </summary>
    public class ReportStateType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ReportStateType
        /// </summary>
        public static readonly ReportStateType COMPLETE = new ReportStateType("COMPLETE");
        /// <summary>
        /// Constant INPROGRESS for ReportStateType
        /// </summary>
        public static readonly ReportStateType INPROGRESS = new ReportStateType("INPROGRESS");
        /// <summary>
        /// Constant STARTED for ReportStateType
        /// </summary>
        public static readonly ReportStateType STARTED = new ReportStateType("STARTED");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ReportStateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportStateType FindValue(string value)
        {
            return FindValue<ReportStateType>(value);
        }

        public static implicit operator ReportStateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant Active for StatusType
        /// </summary>
        public static readonly StatusType Active = new StatusType("Active");
        /// <summary>
        /// Constant Inactive for StatusType
        /// </summary>
        public static readonly StatusType Inactive = new StatusType("Inactive");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SummaryKeyType.
    /// </summary>
    public class SummaryKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AccessKeysPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccessKeysPerUserQuota = new SummaryKeyType("AccessKeysPerUserQuota");
        /// <summary>
        /// Constant AccountAccessKeysPresent for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountAccessKeysPresent = new SummaryKeyType("AccountAccessKeysPresent");
        /// <summary>
        /// Constant AccountMFAEnabled for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountMFAEnabled = new SummaryKeyType("AccountMFAEnabled");
        /// <summary>
        /// Constant AccountSigningCertificatesPresent for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountSigningCertificatesPresent = new SummaryKeyType("AccountSigningCertificatesPresent");
        /// <summary>
        /// Constant AttachedPoliciesPerGroupQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerGroupQuota = new SummaryKeyType("AttachedPoliciesPerGroupQuota");
        /// <summary>
        /// Constant AttachedPoliciesPerRoleQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerRoleQuota = new SummaryKeyType("AttachedPoliciesPerRoleQuota");
        /// <summary>
        /// Constant AttachedPoliciesPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerUserQuota = new SummaryKeyType("AttachedPoliciesPerUserQuota");
        /// <summary>
        /// Constant GroupPolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupPolicySizeQuota = new SummaryKeyType("GroupPolicySizeQuota");
        /// <summary>
        /// Constant Groups for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Groups = new SummaryKeyType("Groups");
        /// <summary>
        /// Constant GroupsPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupsPerUserQuota = new SummaryKeyType("GroupsPerUserQuota");
        /// <summary>
        /// Constant GroupsQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupsQuota = new SummaryKeyType("GroupsQuota");
        /// <summary>
        /// Constant MFADevices for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType MFADevices = new SummaryKeyType("MFADevices");
        /// <summary>
        /// Constant MFADevicesInUse for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType MFADevicesInUse = new SummaryKeyType("MFADevicesInUse");
        /// <summary>
        /// Constant Policies for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Policies = new SummaryKeyType("Policies");
        /// <summary>
        /// Constant PoliciesQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PoliciesQuota = new SummaryKeyType("PoliciesQuota");
        /// <summary>
        /// Constant PolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicySizeQuota = new SummaryKeyType("PolicySizeQuota");
        /// <summary>
        /// Constant PolicyVersionsInUse for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicyVersionsInUse = new SummaryKeyType("PolicyVersionsInUse");
        /// <summary>
        /// Constant PolicyVersionsInUseQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicyVersionsInUseQuota = new SummaryKeyType("PolicyVersionsInUseQuota");
        /// <summary>
        /// Constant ServerCertificates for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType ServerCertificates = new SummaryKeyType("ServerCertificates");
        /// <summary>
        /// Constant ServerCertificatesQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType ServerCertificatesQuota = new SummaryKeyType("ServerCertificatesQuota");
        /// <summary>
        /// Constant SigningCertificatesPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType SigningCertificatesPerUserQuota = new SummaryKeyType("SigningCertificatesPerUserQuota");
        /// <summary>
        /// Constant UserPolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType UserPolicySizeQuota = new SummaryKeyType("UserPolicySizeQuota");
        /// <summary>
        /// Constant Users for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Users = new SummaryKeyType("Users");
        /// <summary>
        /// Constant UsersQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType UsersQuota = new SummaryKeyType("UsersQuota");
        /// <summary>
        /// Constant VersionsPerPolicyQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType VersionsPerPolicyQuota = new SummaryKeyType("VersionsPerPolicyQuota");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SummaryKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryKeyType FindValue(string value)
        {
            return FindValue<SummaryKeyType>(value);
        }

        public static implicit operator SummaryKeyType(string value)
        {
            return FindValue(value);
        }
    }

}