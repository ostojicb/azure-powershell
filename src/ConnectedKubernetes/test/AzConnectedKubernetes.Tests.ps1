$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'AzConnectedKubernetes.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'AzConnectedKubernetes' {
    It 'CreateExpanded' {
        {
            $config = New-AzConnectedKubernetes -ClusterName $env.clusterNameEUS1 -ResourceGroupName $env.resourceGroupEUS -Location $env.locationEUS
            $config.ProvisioningState | Should -Be 'Succeeded'

            $config = New-AzConnectedKubernetes -ClusterName $env.clusterNameEUS2 -ResourceGroupName $env.resourceGroupEUS -Location $env.locationEUS -KubeConfig $HOME\.kube\config -KubeContext $env.kubeContext
            $config.ProvisioningState | Should -Be 'Succeeded'

            # Clear helm azure-arc environment
            helm delete azure-arc --no-hooks
        } | Should -Not -Throw
    }

    It 'List1' {
        {
            $config = Get-AzConnectedKubernetes
            $config.Count | Should -BeGreaterThan 0
        } | Should -Not -Throw
    }

    It 'List' {
        {
            $config = Get-AzConnectedKubernetes -ResourceGroupName $env.resourceGroupEUS
            $config.Count | Should -BeGreaterThan 0
        } | Should -Not -Throw
    }

    It 'UpdateExpanded' {
        {
            $config = Update-AzConnectedKubernetes -ResourceGroupName $env.resourceGroupEUS -Name $env.clusterNameEUS1 -Tag @{'key1'= 1; 'key2'= 2}
            $connaks.Tag.Count | Should -Be 2
        } | Should -Not -Throw
    }

    It 'Get' {
        {
            $config = Get-AzConnectedKubernetes -ResourceGroupName $env.resourceGroupEUS -ClusterName $env.clusterNameEUS1
            $connaks.Tag.Count | Should -Be 2
            $config.Name | Should -Be $env.clusterNameEUS1
        } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' {
        {
            $connaks = Get-AzConnectedKubernetes -ResourceGroupName $env.resourceGroupEUS -Name $env.clusterNameEUS2 | Update-AzConnectedKubernetes -Tag @{'key1'= 1; 'key2'= 2; 'key3'= 3}
            $connaks.Tag.Count | Should -Be 3
        } | Should -Not -Throw
    }

    It 'GetViaIdentity' {
        {
            $config = Get-AzConnectedKubernetes -ResourceGroupName $env.resourceGroupEUS -ClusterName $env.clusterNameEUS2
            $config = Get-AzConnectedKubernetes -InputObject $config
            $connaks.Tag.Count | Should -Be 3
            $config.Name | Should -Be $env.clusterNameEUS2
        } | Should -Not -Throw
    }

    It 'ClusterUserCredential-AAD' {
        {
            $config = Get-AzConnectedClusterUserCredential -ResourceGroupName $env.resourceGroupEUS -ClusterName $env.clusterNameEUS1 -AuthenticationMethod AAD -ClientProxy
            $config.Kubeconfig | Should -Be $env.kubeContext
        } | Should -Not -Throw
    }

    It 'ClusterUserCredential-Token' {
        {
            $config = Get-AzConnectedClusterUserCredential -ResourceGroupName $env.resourceGroupEUS -ClusterName $env.clusterNameEUS2 -AuthenticationMethod Token -ClientProxy
            $config.Kubeconfig | Should -Be $env.kubeContext
        } | Should -Not -Throw
    }

    It 'Delete' {
        {
            Remove-AzConnectedKubernetes -ResourceGroupName $env.resourceGroupEUS -ClusterName $env.clusterNameEUS1
        } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' {
        {
            Get-AzConnectedKubernetes -ResourceGroupName $env.resourceGroupEUS -ClusterName $env.clusterNameEUS2 | Remove-AzConnectedKubernetes
        } | Should -Not -Throw
    }
}
