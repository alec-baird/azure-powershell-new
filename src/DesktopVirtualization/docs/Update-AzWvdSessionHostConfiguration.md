---
external help file:
Module Name: Az.DesktopVirtualization
online version: https://docs.microsoft.com/powershell/module/az.desktopvirtualization/update-azwvdsessionhostconfiguration
schema: 2.0.0
---

# Update-AzWvdSessionHostConfiguration

## SYNOPSIS
Update a SessionHostConfiguration.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzWvdSessionHostConfiguration -HostPoolName <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-ActiveDirectoryInfoDomainName <String>] [-ActiveDirectoryInfoOuPath <String>]
 [-AvailabilityZone <Int32[]>] [-AzureActiveDirectoryInfoMdmProviderGuid <String>]
 [-BootDiagnosticInfoStorageAccountResourceId <String>]
 [-BootDiagnosticInfoType <VirtualMachineBootDiagnosticsType>]
 [-CredentialsPasswordKeyVaultSecretUri <String>] [-CredentialsUsername <String>]
 [-CustomConfigurationScriptUrl <String>] [-CustomInfoResourceId <String>] [-CustomInfoVersion <String>]
 [-DiskInfoType <VirtualMachineDiskType>] [-DomainInfoJoinType <DomainJoinType>] [-FriendlyName <String>]
 [-ImageInfoType <Type>] [-MarketplaceInfoExactVersion <String>] [-MarketplaceInfoOffer <String>]
 [-MarketplaceInfoPublisher <String>] [-MarketplaceInfoSku <String>] [-NetworkInfoSecurityGroupId <String>]
 [-NetworkInfoSubnetId <String>] [-SecurityInfoSecureBootEnabled]
 [-SecurityInfoType <VirtualMachineSecurityType>] [-SecurityInfoVTpmEnabled]
 [-SupportedFirstPartyExtension <Hashtable>] [-VMAdminCredentialsPasswordKeyVaultSecretUri <String>]
 [-VMAdminCredentialsUsername <String>] [-VMLocation <String>] [-VMNamePrefix <String>] [-VMSizeId <String>]
 [-VMTag <Hashtable>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzWvdSessionHostConfiguration -InputObject <IDesktopVirtualizationIdentity>
 [-ActiveDirectoryInfoDomainName <String>] [-ActiveDirectoryInfoOuPath <String>] [-AvailabilityZone <Int32[]>]
 [-AzureActiveDirectoryInfoMdmProviderGuid <String>] [-BootDiagnosticInfoStorageAccountResourceId <String>]
 [-BootDiagnosticInfoType <VirtualMachineBootDiagnosticsType>]
 [-CredentialsPasswordKeyVaultSecretUri <String>] [-CredentialsUsername <String>]
 [-CustomConfigurationScriptUrl <String>] [-CustomInfoResourceId <String>] [-CustomInfoVersion <String>]
 [-DiskInfoType <VirtualMachineDiskType>] [-DomainInfoJoinType <DomainJoinType>] [-FriendlyName <String>]
 [-ImageInfoType <Type>] [-MarketplaceInfoExactVersion <String>] [-MarketplaceInfoOffer <String>]
 [-MarketplaceInfoPublisher <String>] [-MarketplaceInfoSku <String>] [-NetworkInfoSecurityGroupId <String>]
 [-NetworkInfoSubnetId <String>] [-SecurityInfoSecureBootEnabled]
 [-SecurityInfoType <VirtualMachineSecurityType>] [-SecurityInfoVTpmEnabled]
 [-SupportedFirstPartyExtension <Hashtable>] [-VMAdminCredentialsPasswordKeyVaultSecretUri <String>]
 [-VMAdminCredentialsUsername <String>] [-VMLocation <String>] [-VMNamePrefix <String>] [-VMSizeId <String>]
 [-VMTag <Hashtable>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update a SessionHostConfiguration.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ActiveDirectoryInfoDomainName
The domain a virtual machine connected to a hostpool will join.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActiveDirectoryInfoOuPath
The ou path.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityZone
Value for availability zones to be used by the session host.
Should be from [1,2,3].

```yaml
Type: System.Int32[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureActiveDirectoryInfoMdmProviderGuid
The mdm guid.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BootDiagnosticInfoStorageAccountResourceId
Resource Id for the custom storage account to use.
This is required when type is EnableWithCustomStorage.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BootDiagnosticInfoType
The boot diagnostics type used by virtual machine in hostpool session host.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineBootDiagnosticsType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CredentialsPasswordKeyVaultSecretUri
The uri to access the secret that the password is stored in.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CredentialsUsername
The user name to the account.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomConfigurationScriptUrl
The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomInfoResourceId
The resource id of the custom image.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomInfoVersion
Version string for the custom image info.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiskInfoType
The disk type used by virtual machine in hostpool session host.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainInfoJoinType
The type of domain join done by the virtual machine.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FriendlyName
Friendly name to describe this version of the SessionHostConfiguration.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostPoolName
The name of the host pool within the specified resource group

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageInfoType
The type of image session hosts use in the hostpool.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MarketplaceInfoExactVersion
The exact version of the image.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MarketplaceInfoOffer
The offer of the image.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MarketplaceInfoPublisher
The publisher of the image.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MarketplaceInfoSku
The sku of the image.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkInfoSecurityGroupId
The resource ID of the security group.
Any allowable/open ports should be specified in the NSG.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkInfoSubnetId
The resource ID of the subnet.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityInfoSecureBootEnabled
Whether to use secureBoot on the virtual machine.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityInfoType
The security type used by virtual machine in hostpool session host.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityInfoVTpmEnabled
Whether to use vTPM on the virtual machine.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportedFirstPartyExtension
Hashtable that lists first party extensions and whether they are supported or not.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMAdminCredentialsPasswordKeyVaultSecretUri
The uri to access the secret that the password is stored in.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMAdminCredentialsUsername
The user name to the account.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMLocation
The Location for the session host to be created in

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMNamePrefix
The prefix that should be associated with session host names

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMSizeId
The id of the size of a virtual machine connected to a hostpool.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMTag
Hashtable that lists key/value pair tags to apply to the VMs

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IDesktopVirtualizationIdentity>`: Identity Parameter
  - `[ApplicationGroupName <String>]`: The name of the application group
  - `[ApplicationName <String>]`: The name of the application within the specified application group
  - `[DesktopName <String>]`: The name of the desktop within the specified desktop group
  - `[HostPoolName <String>]`: The name of the host pool within the specified resource group
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: The location of the operation result.
  - `[MsixPackageFullName <String>]`: The version specific package full name of the MSIX package within specified hostpool
  - `[OperationResultId <String>]`: The Guid of the operation result.
  - `[OperationStatusId <String>]`: The Guid of the operation status.
  - `[PrivateEndpointConnectionName <String>]`: The name of the private endpoint connection associated with the Azure resource
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[ScalingPlanName <String>]`: The name of the scaling plan.
  - `[ScalingPlanScheduleName <String>]`: The name of the ScalingPlanSchedule
  - `[SessionHostName <String>]`: The name of the session host within the specified host pool
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[UserSessionId <String>]`: The name of the user session within the specified session host
  - `[WorkspaceName <String>]`: The name of the workspace

## RELATED LINKS

