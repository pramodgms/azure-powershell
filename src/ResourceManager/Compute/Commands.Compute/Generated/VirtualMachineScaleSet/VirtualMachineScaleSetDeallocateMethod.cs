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

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateVirtualMachineScaleSetDeallocateDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pVMScaleSetName = new RuntimeDefinedParameter();
            pVMScaleSetName.Name = "VMScaleSetName";
            pVMScaleSetName.ParameterType = typeof(string);
            pVMScaleSetName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pVMScaleSetName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VMScaleSetName", pVMScaleSetName);

            var pInstanceIds = new RuntimeDefinedParameter();
            pInstanceIds.Name = "InstanceId";
            pInstanceIds.ParameterType = typeof(string[]);
            pInstanceIds.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = false
            });
            pInstanceIds.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("InstanceId", pInstanceIds);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 4,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteVirtualMachineScaleSetDeallocateMethod(object[] invokeMethodInputParameters)
        {
            string resourceGroupName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string vmScaleSetName = (string)ParseParameter(invokeMethodInputParameters[1]);
            System.Collections.Generic.IList<string> instanceIds = null;
            if (invokeMethodInputParameters[2] != null)
            {
                var inputArray2 = Array.ConvertAll((object[]) ParseParameter(invokeMethodInputParameters[2]), e => e.ToString());
                instanceIds = inputArray2.ToList();
            }

            var result = VirtualMachineScaleSetsClient.Deallocate(resourceGroupName, vmScaleSetName, instanceIds);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateVirtualMachineScaleSetDeallocateParameters()
        {
            string resourceGroupName = string.Empty;
            string vmScaleSetName = string.Empty;
            var instanceIds = new string[0];

            return ConvertFromObjectsToArguments(
                 new string[] { "ResourceGroupName", "VMScaleSetName", "InstanceIds" },
                 new object[] { resourceGroupName, vmScaleSetName, instanceIds });
        }
    }

    [Cmdlet(VerbsLifecycle.Stop, "AzureRmVmss", DefaultParameterSetName = "InvokeByDynamicParameters")]
    public partial class StopAzureRmVmss : InvokeAzureComputeMethodCmdlet
    {
        public override string MethodName { get; set; }

        protected override void ProcessRecord()
        {
            if (this.ParameterSetName == "InvokeByDynamicParameters")
            {
                this.MethodName = "VirtualMachineScaleSetDeallocate";
            }
            else
            {
                this.MethodName = "VirtualMachineScaleSetPowerOff";
            }
            if (ShouldProcess(this.dynamicParameters["ResourceGroupName"].Value.ToString(), VerbsLifecycle.Stop)
                && (this.dynamicParameters["Force"].IsSet ||
                    this.ShouldContinue(Properties.Resources.ResourceStoppingConfirmation,
                                        "Stop-AzureRmVmss operation")))
            {
                base.ProcessRecord();
            }
        }

        public override object GetDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = false
            });
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParametersForFriendMethod",
                Position = 1,
                Mandatory = true,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = false
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pVMScaleSetName = new RuntimeDefinedParameter();
            pVMScaleSetName.Name = "VMScaleSetName";
            pVMScaleSetName.ParameterType = typeof(string);
            pVMScaleSetName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = false
            });
            pVMScaleSetName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParametersForFriendMethod",
                Position = 2,
                Mandatory = true,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = false
            });
            pVMScaleSetName.Attributes.Add(new AliasAttribute("Name"));
            pVMScaleSetName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VMScaleSetName", pVMScaleSetName);

            var pInstanceIds = new RuntimeDefinedParameter();
            pInstanceIds.Name = "InstanceId";
            pInstanceIds.ParameterType = typeof(string[]);
            pInstanceIds.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = false,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = false
            });
            pInstanceIds.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParametersForFriendMethod",
                Position = 3,
                Mandatory = false,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = false
            });
            pInstanceIds.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("InstanceId", pInstanceIds);

            var pForce = new RuntimeDefinedParameter();
            pForce.Name = "Force";
            pForce.ParameterType = typeof(SwitchParameter);
            pForce.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 4,
                Mandatory = false
            });
            pForce.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParametersForFriendMethod",
                Position = 4,
                Mandatory = false
            });
            pForce.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Force", pForce);

            var pStayProvisioned = new RuntimeDefinedParameter();
            pStayProvisioned.Name = "StayProvisioned";
            pStayProvisioned.ParameterType = typeof(SwitchParameter);
            pStayProvisioned.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParametersForFriendMethod",
                Position = 5,
                Mandatory = true
            });
            pStayProvisioned.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("StayProvisioned", pStayProvisioned);

            return dynamicParameters;
        }
    }
}
