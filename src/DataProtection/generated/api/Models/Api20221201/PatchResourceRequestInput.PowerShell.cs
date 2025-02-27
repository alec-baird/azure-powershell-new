// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Patch Request content for Microsoft.DataProtection resources</summary>
    [System.ComponentModel.TypeConverter(typeof(PatchResourceRequestInputTypeConverter))]
    public partial class PatchResourceRequestInput
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PatchResourceRequestInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PatchResourceRequestInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PatchResourceRequestInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PatchResourceRequestInput" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PatchResourceRequestInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppIdentityDetails) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.DppIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchBackupVaultInput) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchBackupVaultInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchResourceRequestInputTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ISecuritySettings) content.GetValueForProperty("SecuritySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.SecuritySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IFeatureSettings) content.GetValueForProperty("FeatureSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.FeatureSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("SecuritySettingImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySettingImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IImmutabilitySettings) content.GetValueForProperty("SecuritySettingImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySettingImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ISoftDeleteSettings) content.GetValueForProperty("SoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSettingCrossSubscriptionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ICrossSubscriptionRestoreSettings) content.GetValueForProperty("FeatureSettingCrossSubscriptionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.CrossSubscriptionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState?) content.GetValueForProperty("AzureMonitorAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState.CreateFrom);
            }
            if (content.Contains("SoftDeleteState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState?) content.GetValueForProperty("SoftDeleteState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState.CreateFrom);
            }
            if (content.Contains("SoftDeleteRetentionDurationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteRetentionDurationInDay = (double?) content.GetValueForProperty("SoftDeleteRetentionDurationInDay",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteRetentionDurationInDay, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ImmutabilityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).ImmutabilityState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState?) content.GetValueForProperty("ImmutabilityState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).ImmutabilityState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState.CreateFrom);
            }
            if (content.Contains("CrossSubscriptionRestoreState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).CrossSubscriptionRestoreState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState?) content.GetValueForProperty("CrossSubscriptionRestoreState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).CrossSubscriptionRestoreState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PatchResourceRequestInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IDppIdentityDetails) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.DppIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchBackupVaultInput) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchBackupVaultInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.PatchResourceRequestInputTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ISecuritySettings) content.GetValueForProperty("SecuritySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.SecuritySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IFeatureSettings) content.GetValueForProperty("FeatureSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.FeatureSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("SecuritySettingImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySettingImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IImmutabilitySettings) content.GetValueForProperty("SecuritySettingImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SecuritySettingImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ISoftDeleteSettings) content.GetValueForProperty("SoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSettingCrossSubscriptionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.ICrossSubscriptionRestoreSettings) content.GetValueForProperty("FeatureSettingCrossSubscriptionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.CrossSubscriptionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState?) content.GetValueForProperty("AzureMonitorAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState.CreateFrom);
            }
            if (content.Contains("SoftDeleteState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState?) content.GetValueForProperty("SoftDeleteState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState.CreateFrom);
            }
            if (content.Contains("SoftDeleteRetentionDurationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteRetentionDurationInDay = (double?) content.GetValueForProperty("SoftDeleteRetentionDurationInDay",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).SoftDeleteRetentionDurationInDay, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ImmutabilityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).ImmutabilityState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState?) content.GetValueForProperty("ImmutabilityState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).ImmutabilityState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState.CreateFrom);
            }
            if (content.Contains("CrossSubscriptionRestoreState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).CrossSubscriptionRestoreState = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState?) content.GetValueForProperty("CrossSubscriptionRestoreState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20221201.IPatchResourceRequestInputInternal)this).CrossSubscriptionRestoreState, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Patch Request content for Microsoft.DataProtection resources
    [System.ComponentModel.TypeConverter(typeof(PatchResourceRequestInputTypeConverter))]
    public partial interface IPatchResourceRequestInput

    {

    }
}