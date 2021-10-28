
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Get the child resources of a resource on which user has eligible access
.Description
Get the child resources of a resource on which user has eligible access
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.IAuthorizationIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IAuthorizationIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [RoleAssignmentScheduleInstanceName <String>]: The name (hash of schedule name + time) of the role assignment schedule to get.
  [RoleAssignmentScheduleName <String>]: The name (guid) of the role assignment schedule to get.
  [RoleAssignmentScheduleRequestName <String>]: The name of the role assignment to create. It can be any valid GUID.
  [RoleEligibilityScheduleInstanceName <String>]: The name (hash of schedule name + time) of the role eligibility schedule to get.
  [RoleEligibilityScheduleName <String>]: The name (guid) of the role eligibility schedule to get.
  [RoleEligibilityScheduleRequestName <String>]: The name of the role eligibility to create. It can be any valid GUID.
  [RoleManagementPolicyAssignmentName <String>]: The name of format {guid_guid} the role management policy assignment to get.
  [RoleManagementPolicyName <String>]: The name (guid) of the role management policy to get.
  [Scope <String>]: The scope of the role management policy.
.Link
https://docs.microsoft.com/powershell/module/az.resources/get-azroleeligiblechildresource
#>
function Get-AzRoleEligibleChildResource {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IEligibleChildResource])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Path')]
    [System.String]
    # The scope of the role management policy.
    ${Scope},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.IAuthorizationIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Query')]
    [System.String]
    # The filter to apply on the operation.
    # Use $filter=resourceType+eq+'Subscription' to filter on only resource of type = 'Subscription'.
    # Use $filter=resourceType+eq+'subscription'+or+resourceType+eq+'resourcegroup' to filter on resource of type = 'Subscription' or 'ResourceGroup'
    ${Filter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.Resources.Authorization.private\Get-AzRoleEligibleChildResource_Get';
            GetViaIdentity = 'Az.Resources.Authorization.private\Get-AzRoleEligibleChildResource_GetViaIdentity';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
