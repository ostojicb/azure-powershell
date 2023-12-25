---
external help file:
Module Name: Az.DatabaseFleetManager
online version: https://learn.microsoft.com/powershell/module/az.databasefleetmanager/new-azdatabasefleetmanagerfleettier
schema: 2.0.0
---

# New-AzDatabaseFleetManagerFleetTier

## SYNOPSIS
Create a tier.

## SYNTAX

### CreateExpanded (Default)
```
New-AzDatabaseFleetManagerFleetTier -FleetName <String> -ResourceGroupName <String> -TierName <String>
 [-SubscriptionId <String>] [-Capacity <Int32>] [-DatabaseCapacityMax <Double>]
 [-DatabaseCapacityMin <Double>] [-DatabaseSizeGbMax <Int32>] [-Family <String>]
 [-NumOfEmptyPreprovisionedDatabase <Int32>] [-Pooled] [-PoolNumOfDatabasesMax <Int32>] [-Serverless]
 [-ServiceTier <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityFleet
```
New-AzDatabaseFleetManagerFleetTier -FleetInputObject <IDatabaseFleetManagerIdentity> -TierName <String>
 -Parameter <IFleetTier> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityFleetExpanded
```
New-AzDatabaseFleetManagerFleetTier -FleetInputObject <IDatabaseFleetManagerIdentity> -TierName <String>
 [-Capacity <Int32>] [-DatabaseCapacityMax <Double>] [-DatabaseCapacityMin <Double>]
 [-DatabaseSizeGbMax <Int32>] [-Family <String>] [-NumOfEmptyPreprovisionedDatabase <Int32>] [-Pooled]
 [-PoolNumOfDatabasesMax <Int32>] [-Serverless] [-ServiceTier <String>] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzDatabaseFleetManagerFleetTier -FleetName <String> -ResourceGroupName <String> -TierName <String>
 -JsonFilePath <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzDatabaseFleetManagerFleetTier -FleetName <String> -ResourceGroupName <String> -TierName <String>
 -JsonString <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create a tier.

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

### -Capacity
Capacity of provisioned resources in the tier, in units matching the specified service tier, for example vCore for GeneralPurpose.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseCapacityMax
Maximum allocated capacity per database, in units matching the specified service tier.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseCapacityMin
Minimum allocated capacity per database, in units matching the specified service tier.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseSizeGbMax
Maximum database size in Gb.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
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

### -Family
Family of provisioned resources, for example Gen5.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

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
Parameter Sets: CreateViaIdentityFleet, CreateViaIdentityFleetExpanded
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
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumOfEmptyPreprovisionedDatabase
Number of empty preprovisioned databases for fast database provisioning.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameter
A SQL Database Fleet tier.
To construct, see NOTES section for PARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IFleetTier
Parameter Sets: CreateViaIdentityFleet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Pooled
If true, databases are pooled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PoolNumOfDatabasesMax
Maximum number of databases per pool.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the resource group that contains the resource.
You can obtain this value from the Azure Resource Manager API or the portal.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Serverless
If true, serverless resources are provisioned in the tier.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceTier
Service tier of provisioned resources, for example GeneralPurpose.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityFleetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Subscription ID that identifies an Azure subscription.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -TierName
Name of the tier.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

### Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IFleetTier

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DatabaseFleetManager.Models.IFleetTier

## NOTES

## RELATED LINKS

