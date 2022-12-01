---
external help file:
Module Name: Az.DesktopVirtualization
online version: https://docs.microsoft.com/powershell/module/az.desktopvirtualization/update-azwvdhostpoolpost
schema: 2.0.0
---

# Update-AzWvdHostPoolPost

## SYNOPSIS
Initiates a hostpool update or schedule an update for the future.
When validateOnly is true this will only run validations and return warnings and errors.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzWvdHostPoolPost -HostPoolName <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 [-ParameterLogOffDelayMinute <Int32>] [-ParameterLogOffMessage <String>]
 [-ParameterMaintenanceAlert <IMaintenanceAlertsProperties[]>] [-ParameterMaxVmsRemovedDuringUpdate <Int32>]
 [-ParameterSaveOriginalDisk] [-ParameterSessionHostConfigurationName <IAny>]
 [-ScheduledTimeDateTime <DateTime>] [-ScheduledTimeZone <String>] [-ValidateOnly]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzWvdHostPoolPost -InputObject <IDesktopVirtualizationIdentity> [-ParameterLogOffDelayMinute <Int32>]
 [-ParameterLogOffMessage <String>] [-ParameterMaintenanceAlert <IMaintenanceAlertsProperties[]>]
 [-ParameterMaxVmsRemovedDuringUpdate <Int32>] [-ParameterSaveOriginalDisk]
 [-ParameterSessionHostConfigurationName <IAny>] [-ScheduledTimeDateTime <DateTime>]
 [-ScheduledTimeZone <String>] [-ValidateOnly] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Initiates a hostpool update or schedule an update for the future.
When validateOnly is true this will only run validations and return warnings and errors.

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

### -AsJob
Run the command as a job

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

### -NoWait
Run the command asynchronously

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

### -ParameterLogOffDelayMinute
Grace period before logging off users in minutes.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterLogOffMessage
Log off message sent to user for logoff.

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

### -ParameterMaintenanceAlert
The alerts given to customers for hostpool update.
To construct, see NOTES section for PARAMETERMAINTENANCEALERT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IMaintenanceAlertsProperties[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterMaxVmsRemovedDuringUpdate
The maximum virtual machines to be removed during hostpool update.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterSaveOriginalDisk
Whether to save original disk.
True by default.

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

### -ParameterSessionHostConfigurationName
The name of the sessionHostConfiguration to use for the update.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IAny
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

### -ScheduledTimeDateTime
The time the hostpool update is schedule for.

```yaml
Type: System.DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScheduledTimeZone
Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyidview=net-5.0.
Must be set if useLocalTime is true.

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

### -ValidateOnly
When validateOnly is true this will run validations and return warnings and errors if any, hostpool will not be updated.

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

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateValidationResponse

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

`PARAMETERMAINTENANCEALERT <IMaintenanceAlertsProperties[]>`: The alerts given to customers for hostpool update.
  - `[DaysBeforeKickoff <Int32?>]`: The number of days before the scheduled update in which the maintenance alert will be sent.
  - `[Message <String>]`: The alert message.

## RELATED LINKS

