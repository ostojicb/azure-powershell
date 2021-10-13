//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssVM", DefaultParameterSetName = "DefaultParameter")]
    [OutputType(typeof(PSVirtualMachineScaleSetVM))]
    public partial class GetAzureRmVmssVM : ComputeAutomationBaseCmdlet
    {
        protected const string DefaultParameterSet = "DefaultParameter",
                               FriendMethodParameterSet = "FriendMethod";
        private InstanceViewTypes UserDataExpand = InstanceViewTypes.UserData;
        
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                string resourceGroupName = this.ResourceGroupName;
                string vmScaleSetName = this.VMScaleSetName;
                string instanceId = this.InstanceId;

                if (!string.IsNullOrEmpty(resourceGroupName) && !string.IsNullOrEmpty(vmScaleSetName) && !string.IsNullOrEmpty(instanceId))
                {
                    if (this.ParameterSetName.Equals(FriendMethodParameterSet))
                    {
                        var result = VirtualMachineScaleSetVMsClient.GetInstanceView(resourceGroupName, vmScaleSetName, instanceId);
                        var psObject = new PSVirtualMachineScaleSetVMInstanceView();
                        ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSetVMInstanceView, PSVirtualMachineScaleSetVMInstanceView>(result, psObject);
                        WriteObject(psObject);
                    }
                    else if (this.UserData == true)
                    {
                        var result = VirtualMachineScaleSetVMsClient.Get(resourceGroupName, vmScaleSetName, instanceId, UserDataExpand);
                        var psObject = new PSVirtualMachineScaleSetVM();
                        ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSetVM, PSVirtualMachineScaleSetVM>(result, psObject);
                        WriteObject(psObject);
                    }
                    else
                    {
                        var result = VirtualMachineScaleSetVMsClient.Get(resourceGroupName, vmScaleSetName, instanceId);
                        var psObject = new PSVirtualMachineScaleSetVM();
                        ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSetVM, PSVirtualMachineScaleSetVM>(result, psObject);
                        WriteObject(psObject);
                    }
                }
                else if (!string.IsNullOrEmpty(resourceGroupName) && !string.IsNullOrEmpty(vmScaleSetName))
                {
                    if (this.ParameterSetName.Equals("FriendMethod"))
                    {
                        var expand = new Microsoft.Rest.Azure.OData.ODataQuery<VirtualMachineScaleSetVM>();
                        expand.Expand = "instanceView";

                        var result = VirtualMachineScaleSetVMsClient.List(resourceGroupName, vmScaleSetName, expand);
                        var resultList = result.ToList();
                        var nextPageLink = result.NextPageLink;
                        while (!string.IsNullOrEmpty(nextPageLink))
                        {
                            var pageResult = VirtualMachineScaleSetVMsClient.ListNext(nextPageLink);
                            foreach (var pageItem in pageResult)
                            {
                                resultList.Add(pageItem);
                            }
                            nextPageLink = pageResult.NextPageLink;
                        }
                        var psObject = new List<PSVirtualMachineScaleSetVMList>();
                        foreach (var r in resultList)
                        {
                            psObject.Add(ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSetVM, PSVirtualMachineScaleSetVMList>(r));
                        }
                        WriteObject(psObject, true);
                    }
                    else
                    {
                        var result = VirtualMachineScaleSetVMsClient.List(resourceGroupName, vmScaleSetName);
                        var resultList = result.ToList();
                        var nextPageLink = result.NextPageLink;
                        while (!string.IsNullOrEmpty(nextPageLink))
                        {
                            var pageResult = VirtualMachineScaleSetVMsClient.ListNext(nextPageLink);
                            foreach (var pageItem in pageResult)
                            {
                                resultList.Add(pageItem);
                            }
                            nextPageLink = pageResult.NextPageLink;
                        }
                        var psObject = new List<PSVirtualMachineScaleSetVMList>();
                        foreach (var r in resultList)
                        {
                            psObject.Add(ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSetVM, PSVirtualMachineScaleSetVMList>(r));
                        }
                        WriteObject(psObject, true);
                    }
                }
            });
        }

        [Parameter(
            ParameterSetName = DefaultParameterSet,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [Parameter(
            ParameterSetName = FriendMethodParameterSet,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameterSet,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        [Parameter(
            ParameterSetName = FriendMethodParameterSet,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachineScaleSets", "ResourceGroupName")]
        [Alias("Name")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameterSet,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        [Parameter(
            ParameterSetName = FriendMethodParameterSet,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string InstanceId { get; set; }

        [Parameter(
            ParameterSetName = FriendMethodParameterSet,
            Mandatory = true)]
        public SwitchParameter InstanceView { get; set; }
        
        [Parameter(
            Mandatory = false,
            ParameterSetName = DefaultParameterSet,
            HelpMessage = "UserData for the Vmss, which will be base-64 encoded. Customer should not pass any secrets in here.",
            ValueFromPipeline = true)]
        [Parameter(
            Mandatory = false,
            ParameterSetName = FriendMethodParameterSet,
            HelpMessage = "UserData for the Vmss, which will be base-64 encoded. Customer should not pass any secrets in here.",
            ValueFromPipeline = true)]
        public SwitchParameter UserData { get; set; }
    }
}
