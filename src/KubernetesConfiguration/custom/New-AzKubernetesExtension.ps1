
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a new Kubernetes Cluster Extension.
.Description
Create a new Kubernetes Cluster Extension.
.Example
PS C:\> New-AzKubernetesExtension -ClusterName azps_test_cluster -ClusterType ConnectedClusters -Name azps_test_extension -ResourceGroupName azps_test_group -ExtensionType Microsoft.Arcdataservices

Name                ExtensionType             Version      ProvisioningState AutoUpgradeMinorVersion ResourceGroupName
----                -------------             -------      ----------------- ----------------------- -----------------
azps_test_extension microsoft.arcdataservices 1.0.16701001 Succeeded         True                    azps_test_group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IExtension
.Link
https://docs.microsoft.com/powershell/module/az.kubernetesconfiguration/new-azextension
#>
function New-AzKubernetesExtension {
    [Alias('New-AzK8sExtension')]
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IExtension])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The name of the kubernetes cluster.
        ${ClusterName},

        [Parameter(Mandatory)]
        [ValidateSet('ConnectedClusters', 'ManagedClusters')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        ${ClusterType},

        [Parameter(Mandatory)]
        [Alias('ExtensionName')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # Name of the Extension.
        ${Name},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The Azure subscription ID.
        # This is a GUID-formatted string (e.g.
        # 00000000-0000-0000-0000-000000000000)
        ${SubscriptionId},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType])]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType]
        # The identity type.
        ${AkAssignedIdentityType},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Flag to note if this extension participates in auto upgrade of minor version, or not.
        ${AutoUpgradeMinorVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Namespace where the extension Release must be placed, for a Cluster scoped extension.
        # If this namespace does not exist, it will be created
        ${ClusterReleaseNamespace},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IExtensionPropertiesConfigurationProtectedSettings]))]
        [System.Collections.Hashtable]
        # Configuration settings that are sensitive, as name-value pairs for configuring this extension.
        ${ConfigurationProtectedSetting},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IExtensionPropertiesConfigurationSettings]))]
        [System.Collections.Hashtable]
        # Configuration settings, as name-value pairs for configuring this extension.
        ${ConfigurationSetting},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Type of the Extension, of which this resource is an instance of.
        # It must be one of the Extension Types registered with Microsoft.KubernetesConfiguration by the Extension publisher.
        ${ExtensionType},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType])]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType]
        # The identity type.
        ${IdentityType},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Namespace where the extension will be created for an Namespace scoped extension.
        # If this namespace does not exist, it will be created
        ${NamespaceTargetNamespace},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # ReleaseTrain this extension participates in for auto-upgrade (e.g.
        # Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.
        ${ReleaseTrain},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Version of the extension for this extension, if it is 'pinned' to a specific version.
        # autoUpgradeMinorVersion must be 'false'.
        ${Version},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        if ($ClusterType -eq 'ManagedClusters') {
            $PSBoundParameters.Add('ClusterRp', 'Microsoft.ContainerService')
        }
        elseif ($ClusterType -eq 'ConnectedClusters') {
            $PSBoundParameters.Add('ClusterRp', 'Microsoft.Kubernetes')
        }

        Az.KubernetesConfiguration.internal\New-AzKubernetesExtension @PSBoundParameters
    }
}