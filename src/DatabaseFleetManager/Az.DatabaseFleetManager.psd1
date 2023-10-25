@{
  GUID = 'b924f966-9df7-435c-8514-e3dbfadcbdc1'
  RootModule = './Az.DatabaseFleetManager.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: DatabaseFleetManager cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.DatabaseFleetManager.private.dll'
  FormatsToProcess = './Az.DatabaseFleetManager.format.ps1xml'
  FunctionsToExport = 'Disable-AzDatabaseFleetManagerFleetTier', 'Get-AzDatabaseFleetManagerAuthorizedPrincipal', 'Get-AzDatabaseFleetManagerFirewallRule', 'Get-AzDatabaseFleetManagerFleet', 'Get-AzDatabaseFleetManagerFleetDatabase', 'Get-AzDatabaseFleetManagerFleetspace', 'Get-AzDatabaseFleetManagerFleetTier', 'Invoke-AzDatabaseFleetManagerServerMigration', 'New-AzDatabaseFleetManagerFleetDatabase', 'Remove-AzDatabaseFleetManagerAuthorizedPrincipal', 'Remove-AzDatabaseFleetManagerFirewallRule', 'Remove-AzDatabaseFleetManagerFleet', 'Remove-AzDatabaseFleetManagerFleetDatabase', 'Remove-AzDatabaseFleetManagerFleetspace', 'Rename-AzDatabaseFleetManagerFleetDatabaseTier', 'Update-AzDatabaseFleetManagerFleet', 'Update-AzDatabaseFleetManagerFleetDatabase', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'DatabaseFleetManager'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
