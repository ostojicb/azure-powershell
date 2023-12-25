---
external help file:
Module Name: Az.DatabaseFleetManager
online version: https://learn.microsoft.com/powershell/module/az.databasefleetmanager/rename-azdatabasefleetmanagerdatabasetier
schema: 2.0.0
---

# Rename-AzDatabaseFleetManagerDatabaseTier

## SYNOPSIS
Moves database to a different tier.

## SYNTAX

### ChangeExpanded (Default)
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String> -FleetName <String> -FleetspaceName <String>
 -ResourceGroupName <String> [-SubscriptionId <String>] [-TargetTierName <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Change
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String> -FleetName <String> -FleetspaceName <String>
 -ResourceGroupName <String> -Parameter <IDatabaseMoveDefinition> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaIdentity
```
Rename-AzDatabaseFleetManagerDatabaseTier -InputObject <IDatabaseFleetManagerIdentity>
 -Parameter <IDatabaseMoveDefinition> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ChangeViaIdentityExpanded
```
Rename-AzDatabaseFleetManagerDatabaseTier -InputObject <IDatabaseFleetManagerIdentity>
 [-TargetTierName <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ChangeViaIdentityFleet
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String>
 -FleetInputObject <IDatabaseFleetManagerIdentity> -FleetspaceName <String>
 -Parameter <IDatabaseMoveDefinition> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ChangeViaIdentityFleetExpanded
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String>
 -FleetInputObject <IDatabaseFleetManagerIdentity> -FleetspaceName <String> [-TargetTierName <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaIdentityFleetspace
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String>
 -FleetspaceInputObject <IDatabaseFleetManagerIdentity> -Parameter <IDatabaseMoveDefinition>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaIdentityFleetspaceExpanded
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String>
 -FleetspaceInputObject <IDatabaseFleetManagerIdentity> [-TargetTierName <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaJsonFilePath
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String> -FleetName <String> -FleetspaceName <String>
 -ResourceGroupName <String> -JsonFilePath <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaJsonString
```
Rename-AzDatabaseFleetManagerDatabaseTier -DatabaseName <String> -FleetName <String> -FleetspaceName <String>
 -ResourceGroupName <String> -JsonString <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Moves database to a different tier.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
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

### -DatabaseName
Name of the database.

```yaml
Type: System.String
Parameter Sets: Change, ChangeExpanded, ChangeViaIdentityFleet, ChangeViaIdentityFleetExpanded, ChangeViaIdentityFleetspace, ChangeViaIdentityFleetspaceExpanded, ChangeViaJsonFilePath, ChangeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

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

### -FleetInputObject
Identity Parameter
To construct, see NOTES section for FLEETINPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IDatabaseFleetManagerIdentity
Parameter Sets: ChangeViaIdentityFleet, ChangeViaIdentityFleetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FleetName
Name of the database fleet.

```yaml
Type: System.String
Parameter Sets: Change, ChangeExpanded, ChangeViaJsonFilePath, ChangeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FleetspaceInputObject
Identity Parameter
To construct, see NOTES section for FLEETSPACEINPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IDatabaseFleetManagerIdentity
Parameter Sets: ChangeViaIdentityFleetspace, ChangeViaIdentityFleetspaceExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FleetspaceName
Name of the fleetspace.

```yaml
Type: System.String
Parameter Sets: Change, ChangeExpanded, ChangeViaIdentityFleet, ChangeViaIdentityFleetExpanded, ChangeViaJsonFilePath, ChangeViaJsonString
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
Type: Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IDatabaseFleetManagerIdentity
Parameter Sets: ChangeViaIdentity, ChangeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Change operation

```yaml
Type: System.String
Parameter Sets: ChangeViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Change operation

```yaml
Type: System.String
Parameter Sets: ChangeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
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

### -Parameter
.
To construct, see NOTES section for PARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IDatabaseMoveDefinition
Parameter Sets: Change, ChangeViaIdentity, ChangeViaIdentityFleet, ChangeViaIdentityFleetspace
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the resource group that contains the resource.
You can obtain this value from the Azure Resource Manager API or the portal.

```yaml
Type: System.String
Parameter Sets: Change, ChangeExpanded, ChangeViaJsonFilePath, ChangeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Subscription ID that identifies an Azure subscription.

```yaml
Type: System.String
Parameter Sets: Change, ChangeExpanded, ChangeViaJsonFilePath, ChangeViaJsonString
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetTierName
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded, ChangeViaIdentityExpanded, ChangeViaIdentityFleetExpanded, ChangeViaIdentityFleetspaceExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IDatabaseFleetManagerIdentity

### Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IDatabaseMoveDefinition

## OUTPUTS

### System.Boolean

## NOTES

## RELATED LINKS

