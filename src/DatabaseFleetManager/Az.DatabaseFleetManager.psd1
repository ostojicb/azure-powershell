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
  FunctionsToExport = 'Disable-AzDatabaseFleetManagerFleetTier', 'Get-AzDatabaseFleetManagerAuthorizedPrincipal', 'Get-AzDatabaseFleetManagerDatabase', 'Get-AzDatabaseFleetManagerFirewallRule', 'Get-AzDatabaseFleetManagerFleet', 'Get-AzDatabaseFleetManagerFleetspace', 'Get-AzDatabaseFleetManagerFleetTier', 'Invoke-AzDatabaseFleetManagerServerMigration', 'New-AzDatabaseFleetManagerAuthorizedPrincipal', 'New-AzDatabaseFleetManagerDatabase', 'New-AzDatabaseFleetManagerFirewallRule', 'New-AzDatabaseFleetManagerFleet', 'New-AzDatabaseFleetManagerFleetspace', 'New-AzDatabaseFleetManagerFleetTier', 'Remove-AzDatabaseFleetManagerAuthorizedPrincipal', 'Remove-AzDatabaseFleetManagerDatabase', 'Remove-AzDatabaseFleetManagerFirewallRule', 'Remove-AzDatabaseFleetManagerFleet', 'Remove-AzDatabaseFleetManagerFleetspace', 'Rename-AzDatabaseFleetManagerDatabaseTier', 'Update-AzDatabaseFleetManagerAuthorizedPrincipal', 'Update-AzDatabaseFleetManagerDatabase', 'Update-AzDatabaseFleetManagerFirewallRule', 'Update-AzDatabaseFleetManagerFleet', 'Update-AzDatabaseFleetManagerFleetspace', 'Update-AzDatabaseFleetManagerFleetTier'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'DatabaseFleetManager'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
