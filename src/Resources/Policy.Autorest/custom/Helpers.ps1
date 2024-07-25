
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

# split policy ids into usable parts
function ParsePolicyId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy definition
    param($resourceId, $policyType)

    # validate args
    if (!$resourceId) {
        throw 'ParsePolicyId(resourceId, policyType) argument error: resourceId must be provided.'
    }

    if (!$policyType) {
        # extract policyType
        $temp = $resourceId -split '/providers/Microsoft.Authorization/'
        if ($temp.Length -lt 2) {
            throw 'parsePolicy(resourceId, policyType) argument error: resourceId is not a Microsoft.Authorization resource type'
        }

        $policyType = ($temp[1] -split '/')[0]
    }

    if (!$policyType) {
        throw 'ParsePolicyId(resourceId, policyType) argument error: unable to find type name.'
    }

    $mark = "/providers/Microsoft.Authorization/$($policyType)/"
    $parts = $resourceId -split $mark
    $scope = $parts[0]
    $name = ''

    if ($parts.Length -gt 1) {
        $parts = $parts[1] -split '/'
        $name = $parts[0]
        if (($parts.Length -gt 2) -and ($parts[1] -eq 'versions')) {
            $parsedVersion = ParsePolicyVersion $parts[2]
        }
    }

    $scopeType = 'none'
    $subId = ''
    $mgName = ''
    $rgName = ''
    $resource = ''
    $resNamespace = ''
    $resType = ''
    $resName = ''

    if (!$scope) {
        $scopeType = 'builtin'
    }
    elseif ($scope -like '/providers/Microsoft.Management/managementGroups/*') {
        $scopeType = 'mgname'
        $mgName = ($scope -split '/providers/Microsoft.Management/managementGroups/')[1]
    }
    elseif ($scope -like '/subscriptions/*/resourceGroups/*/*') {
        $scopeType = 'resource'
        $temp = ($scope -split '/subscriptions/')[1]
        $temp = ($temp -split '/resourceGroups/')
        $subId = $temp[0]
        $temp = ($temp[1] -split '/providers/')
        $rgName = $temp[0]
        $temp = $temp[1] -split '/'
        if ($temp.Length -gt 2) {
            $resNamespace = $temp[0]
            $resType = $temp[1..($temp.Length-2)] -join '/'
            $resName = $temp[$temp.Length-1]
        }

        $resource = $scope
    }
    elseif ($scope -like '/subscriptions/*/resourceGroups/*') {
        $scopeType = 'rgname'
        $temp = ($scope -split '/subscriptions/')[1]
        $temp = ($temp -split '/resourceGroups/')
        $subId = $temp[0]
        $rgName = $temp[1]
    }
    elseif ($scope -like '/subscriptions/*') {
        $scopeType = 'subId'
        $subId = ($scope -split '/subscriptions/')[1]
    }

    $artifactRef = ''

    $artifact = $scope + $mark + $name
    if ($parsedVersion.VersionRef) {
        $artifactRef = "$artifact/versions/$($parsedVersion.VersionRef)"
    }

    return @{
        PolicyType = $policyType
        Scope = $scope
        ScopeType = $scopeType
        SubscriptionId = $subId
        ManagementGroupName = $mgName
        ResourceGroupName = $rgName
        Resource = $resource
        ResourceNamespace = $resNamespace
        ResourceType = $resType
        ResourceName = $resName
        Name = $name
        Artifact = $artifact
        ArtifactRef = $artifactRef
        Version = $parsedVersion.Version
        Major = $parsedVersion.Major
        Minor = $parsedVersion.Minor
        Patch = $parsedVersion.Patch
        Suffix = $parsedVersion.Suffix
        VersionRef = $parsedVersion.VersionRef
        VersionMajorRef = $parsedVersion.VersionMajorRef
        VersionMinorRef = $parsedVersion.VersionMinorRef
    }
}

# parse policy version with format: (ddd|*).(ddd|*).(ddd|*)[-suffix]
function ParsePolicyVersion {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy definition
    param($version)

    $parts = $version -split '\.'
    $major = $parts[0]
    $minor = ''
    if ($parts.Length -gt 1) {
        $minor = $parts[1]
    }

    $patch = ''
    $suffix = ''
    if ($parts.Length -gt 2) {
        $parts = $parts[2] -split '-'
        $patch = $parts[0]
        if ($parts.Length -gt 1) {
            $suffix = $parts[1]
        }
    }

    $versionMinorRef = ''
    $versionMajorRef = @($major,'*','*') -join '.'
    if ($minor -ne '*') {
        $versionMinorRef = @($major,$minor,'*') -join '.'
    }

    if ($suffix) {
        if ($versionMinorRef) {
            $versionMinorRef = $versionMinorRef + '-' + $suffix
        }

        $versionMajorRef = $versionMajorRef + '-' + $suffix
    }

    $versionRef = ''
    if ($versionMinorRef) {
        $versionRef = $versionMinorRef
    }
    else {
        $versionRef = $versionMajorRef
    }

    return @{
        Version = $version
        Major = $major
        Minor = $minor
        Patch = $patch
        Suffix = $suffix
        VersionRef = $versionRef
        VersionMajorRef = $versionMajorRef
        VersionMinorRef = $versionMinorRef
    }
}

# split policy definition resourceId into its parts (used externally)
function ParsePolicyDefinitionId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy definition
    param($ResourceId)

    ParsePolicyId $ResourceId 'policyDefinitions'
}

# split policy set definition resourceId into its parts
function ParsePolicySetDefinitionId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy set definition
    param($ResourceId)

    ParsePolicyId $ResourceId 'policySetDefinitions'
}

# split policy assignment resourceId into its parts
function ParsePolicyAssignmentId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy set definition
    param($ResourceId)

    ParsePolicyId $ResourceId 'policyAssignments'
}

# split policy assignment resourceId into its parts
function ParsePolicyExemptionId {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    # the resource Id of a policy set definition
    param($resourceId)

    ParsePolicyId $ResourceId 'policyExemptions'
}

# Wrapper for JSON -> PSObject conversion that works on both Core and Desktop editions
function ConvertFrom-JsonSafe
{
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [Parameter(ValueFromPipeline)]
        $InputObject,
        [switch]$AsHashtable = $false
    )

    if ($PSVersionTable.PSEdition -eq 'Core') {
        ConvertFrom-Json $InputObject -AsHashtable:$AsHashtable
    }
    elseif ($AsHashtable) {
        # ConvertFrom-Json on Windows Powershell doesn't support -AsHashtable parameter
        $converted = ConvertParameterInput ($InputObject | ConvertFrom-Json)
        if (($converted -is [array]) -and ($converted.Count -eq 1)) {
            return $converted[0]
        }
        else {
            return $converted
        }
    }
    else {
        ConvertFrom-Json $InputObject
    }
}

# convert the parameter object (could be either hashtable or PSCustomObject) to policy-formatted hashtable suitable for autorest serializers
function ConvertParameterObject
{
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param ($InputObject)

    $returnValue = @{}

    if ($InputObject -is [hashtable]) {
        foreach ($key in $InputObject.Keys) {
            $returnValue[$key] = @{ value = (ConvertParameterInput -InputObject $InputObject[$key]) }
        }
    }
    else {
        foreach ($property in $InputObject.PSObject.Properties) {
            $returnValue[$property.Name] = @{ value = (ConvertParameterInput -InputObject $InputObject.PSObject.Properties[$property.Name]) }
        }
    }

    return $returnValue
}

# Convert input parameter value to hashtable type expected by the autorest serializers
function ConvertParameterArray
{
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param ($InputObject)

    if ($InputObject -is [array])
    {
        $collection = @(
            foreach ($object in $InputObject) { ConvertParameterArray $object }
        )

        Write-Output -NoEnumerate $collection
    }
    elseif ($InputObject -is [hashtable])
    {
        return $InputObject
    }
    elseif ($InputObject -is [PSObject])
    {
        $hash = @{}

        foreach ($property in $InputObject.PSObject.Properties)
        {
            $hash[$property.Name] = (ConvertParameterArray $property.Value).PSObject.BaseObject
        }

        $hash
    }
    else {
        return $InputObject
    }
}

# convert various parameter input formats to policy-formatted hashtable suitable for autorest serializers
function ConvertParameterInput
{
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param ($InputObject)

    # traverse collections to ensure nested values are all processed
    if ($InputObject -is [hashtable]) {
        $returnValue = @{}
        foreach ($key in $InputObject.Keys) {
            $returnValue[$key] = (ConvertParameterInput $InputObject[$key])
        }

        return $returnValue
    }
    elseif ($InputObject -is [array]) {
        $returnValue = @()
        foreach ($object in $InputObject) {
            $returnValue += (ConvertParameterInput $object)
        }

        return ,$returnValue
    }
    elseif ($InputObject -is [PSObject])
    {
        $returnValue = @{}
        foreach ($property in $InputObject.PSObject.Properties) {
            $returnValue[$property.Name] = (ConvertParameterInput $property.Value)
        }

        return $returnValue
    }
    else {
        return $InputObject
    }
}

# Convert output hashtable object output by autorest serializers to PSCustomObject format for legacy support
function ConvertObjectToPSObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param($InputObject)

    if ($null -eq $InputObject) {
        return [PSCustomObject]$null
    }

    if ($InputObject -is [array]) {
        return ,@(foreach ($obj in $InputObject) { ConvertObjectToPSObject $obj })
    }

    if (!$InputObject.ToJsonString) {
        return [PSCustomObject]$InputObject
    }

    $jsonString = $InputObject.ToJsonString()
    if ($jsonString -is [array]) {
        $jsonString = "[$([System.String]::Join(',', $jsonString))]"
    }

    ConvertFrom-JsonSafe $jsonString
}

function GetPSObjectProperty {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param (
        [PSObject]$PropertyObject,
        [string]$PropertyPath
    )

    $propertyNames = $PropertyPath.Split('.')
    $tmpObject = $PropertyObject
    foreach ($propertyName in $propertyNames)
    {
        $propertyInfo = $tmpObject.PSObject.Properties[$propertyName]
        if ($propertyInfo)
        {
            if ($propertyInfo.Value -is [PSObject])
            {
                $tmpObject = [PSObject]$propertyInfo.Value
                continue
            }

            return $propertyInfo.Value
        }
    }

    return $tmpObject
}

# tests whether the given string is a Uri
function Test-Uri {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param([string]$Value)

    $uri = ''
    [System.Uri]::TryCreate($Value, [System.UriKind]::Absolute, [ref]$uri)
}

# issues a GET to the given address and returns the contents
function Get-UriContent {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param([string]$UriAddress)

    $response = Invoke-WebRequest $UriAddress -DisableKeepAlive -Method Get
    if ($response.StatusCode -eq 200) {
        return $response.Content
    }
}

# if the given string is a file path or URI, returns the contents of the file or web page
# otherwise returns the original string
function GetFileUriOrStringParameterValue {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param([string]$parameterValue)

    if (Test-Path $parameterValue) {
        Get-Content $parameterValue | Out-String
    }
    else {
        if (Test-Uri $parameterValue) {
            Get-UriContent $parameterValue
        }
        else {
            $parameterValue
        }
    }
}

function ResolvePolicyParameter {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$ParameterName,
        [string]$ParameterValue,
        [bool]$Debug = $false
    )

    $policy = GetFileUriOrStringParameterValue $ParameterValue
    if ($debug) {
        Write-Host -ForegroundColor Cyan "Parameter ${ParameterName}:" $policy
    }

    $policyParameter = ConvertFrom-JsonSafe -AsHashtable $policy
    if ($policyParameter.properties) {
        return $policyParameter.properties
    } else {
        return $policyParameter
    }
}

function ResolvePolicyMetadataParameter {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        $MetadataValue,
        [bool]$Debug = $false
    )

    if ($metadataValue -is [hashtable]) {
        return $metadataValue
    }

    if ([System.String]::IsNullOrEmpty($metadataValue)) {
        return $metadataValue
    }

    $metadata = (GetFileUriOrStringParameterValue $metadataValue).Trim()
    if ($debug) {
        Write-Host -ForegroundColor Cyan Metadata: $metadata
    }

    if ($metadata -like '@{*') {
        # probably a PSCustomObject, try converting to hashtable
        return (Invoke-Expression($metadata.Replace('=',"='").Replace(';',"';").Replace('}',"'}")))
    }

    # otherwise it should be a JSON string
    if ($metadata -like '{*}') {
        return $metadata | ConvertFrom-JsonSafe -AsHashtable
    }

    throw "Unrecognized metadata format - value: [$($metadataValue)], type: [$($metadataValue.GetType())]"
}

# construct the full Id of a resource given the various parts (only used internally in this file)
function resolvePolicyArtifact {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$name,
        [string]$subscriptionId,
        [string]$managementGroupName,
        [string]$id,
        [string]$policyType
    )

    $scope = ''
    $scopeType = 'none'
    $scopeName = ''
    $resourceId = '<invalid>'

    if ($id -and !$subscriptionId -and !$managementGroupName) {
        $resolved = ParsePolicyId $id $policyType
        $scope = $resolved.Scope
        $scopeType = $resolved.ScopeType
        switch ($scopeType) {
            'subId' {
                $subscriptionId = $resolved.SubscriptionId
                $scopeName = "subscription $($subscriptionId)"
            }
            'mgName' {
                $managementGroupName = $resolved.ManagementGroupName
                $scopeName = "management group $($managementGroupName)"
            }
            'rgname' {
                $subscriptionId = $resolved.SubscriptionId
                $scopeName = "resource group $($resolved.ResourceGroupName) (subId: $($subscriptionId))"
            }
            'resource' {
                $subscriptionId = $resolved.SubscriptionId
                $scopeName = "resource id $($resolved.Resource)"
            }
            'none' {
                $scopeName = "scope $($scope)"
            }
        }

        $name = $resolved.Name
        $resourceId = $id
    }
    else {
        if ($name) {
            if ($managementGroupName) {
                $scopeType = 'mgName'
                $scopeName = "management group $($managementGroupName)"
                $scope = "/providers/Microsoft.Management/managementGroups/$($managementGroupName)"
            }
            else {
                if (!$subscriptionId) {
                    $subscriptionId = (Get-SubscriptionId)
                }
                $scopeType = 'subId'
                $scopeName = "subscription $($subscriptionId)"
                $scope = "/subscriptions/$($subscriptionId)"
            }

            $resourceId = "$($scope)/providers/Microsoft.Authorization/$($policyType)/$($name)"
        }
    }

    return @{
        Scope = $scope;
        ScopeType = $scopeType
        ScopeName = $scopeName;
        Name = $name;
        SubscriptionId = $subscriptionId
        ManagementGroupName = $managementGroupName
        ResourceId = $resourceId
        ResourceGroupName = $resolved.ResourceGroupName
        ResourceNamespace = $resolved.ResourceNamespace
        ResourceType = $resolved.ResourceType
        ResourceName = $resolved.ResourceName
    }
}

function ResolvePolicyDefinition {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$SubscriptionId,
        [string]$ManagementGroupName,
        [string]$Id
    )

    resolvePolicyArtifact $Name $SubscriptionId $ManagementGroupName $Id 'policyDefinitions'
}

function ResolvePolicySetDefinition {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$SubscriptionId,
        [string]$ManagementGroupName,
        [string]$Id
    )

    resolvePolicyArtifact $Name $SubscriptionId $ManagementGroupName $Id 'policySetDefinitions'
}

function ResolvePolicyAssignment {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$Scope,
        [string]$Id
    )

    if ($Id) {
        $resourceId = $Id
    }
    elseif ($Scope) {
        $resourceId = "$($Scope)/providers/Microsoft.Authorization/policyAssignments/$($Name)"
    }
    else {
        $resourceId = "/subscriptions/$($(Get-SubscriptionId))/providers/Microsoft.Authorization/policyAssignments/$($Name)"
    }

    resolvePolicyArtifact $null $null $null $resourceId 'policyAssignments'
}

function ResolvePolicyExemption {
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotExportAttribute()]
    param(
        [string]$Name,
        [string]$Scope,
        [string]$Id
    )

    if ($Id) {
        $resourceId = $Id
    }
    elseif ($Scope) {
        $resourceId = "$($Scope)/providers/Microsoft.Authorization/policyExemptions/$($Name)"
    }
    else {
        $resourceId = "/subscriptions/$($(Get-SubscriptionId))/providers/Microsoft.Authorization/policyExemptions/$($Name)"
    }

    resolvePolicyArtifact $null $null $null $resourceId 'policyExemptions'
}

function LocationCompleter(
    $commandName,
    $parameterName,
    $wordToComplete,
    $commandAst,
    $fakeBoundParameter
)
{
    if ($global:AzPSPolicyCachedLocations.Count -le 0) {
        $response = Invoke-AzRestMethod -Uri "https://management.azure.com/subscriptions/$($(Get-SubscriptionId))/locations?api-version=2022-12-01" -Method GET
        $global:AzPSPolicyCachedLocations = ($response.Content | ConvertFrom-JsonSafe).value | Sort-Object -Property name | Select-Object -ExpandProperty name
    }

    # If you see the following error, it means your context access has expired
    #   The given key 'AzureAttestationServiceEndpointSuffix' was not present in the dictionary.
    $global:AzPSPolicyCachedLocations | Where-Object { $_ -like "$wordToComplete*" }
}

function Get-SubscriptionId {
    $script = Resolve-Path "$PSScriptRoot/../utils/Get-SubscriptionIdTestSafe.ps1"
    return . $script
}

function Get-ExtraParameters
(
    $DefaultProfile,
    $Break,
    $HttpPipelineAppend,
    $HttpPipelinePrepend,
    $Proxy,
    $ProxyCredential,
    $ProxyUseDefaultCredentials
) {
    $parms = @{}
    if ($PSBoundParameters['DefaultProfile']) {
        $parms['DefaultProfile'] = $PSBoundParameters['DefaultProfile']
    }

    if ($PSBoundParameters['Break']) {
        $parms['Break'] = $PSBoundParameters['Break']
    }

    if ($PSBoundParameters['HttpPipelineAppend']) {
        $parms['HttpPipelineAppend'] = $PSBoundParameters['HttpPipelineAppend']
    }

    if ($PSBoundParameters['HttpPipelinePrepend']) {
        $parms['HttpPipelinePrepend'] = $PSBoundParameters['HttpPipelinePrepend']
    }

    if ($PSBoundParameters['Proxy']) {
        $parms['Proxy'] = $PSBoundParameters['Proxy']
    }

    if ($PSBoundParameters['ProxyCredential']) {
        $parms['ProxyCredential'] = $PSBoundParameters['ProxyCredential']
    }

    if ($PSBoundParameters['ProxyUseDefaultCredentials']) {
        $parms['ProxyUseDefaultCredentials'] = $PSBoundParameters['ProxyUseDefaultCredentials']
    }

    return $parms
}

# register the location completer for New-AzPolicyAssignment
Register-ArgumentCompleter -CommandName New-AzPolicyAssignment -ParameterName Location -ScriptBlock ${function:LocationCompleter}

# cache Azure locations to be used by the location completer (Get-AzLocation is not available in this context, need to use REST)
$global:AzPSPolicyCachedLocations = @()