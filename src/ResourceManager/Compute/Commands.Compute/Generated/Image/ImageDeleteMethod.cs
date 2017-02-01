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
        protected object CreateImageDeleteDynamicParameters()
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

            var pImageName = new RuntimeDefinedParameter();
            pImageName.Name = "ImageName";
            pImageName.ParameterType = typeof(string);
            pImageName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pImageName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ImageName", pImageName);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 3,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteImageDeleteMethod(object[] invokeMethodInputParameters)
        {
            string resourceGroupName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string imageName = (string)ParseParameter(invokeMethodInputParameters[1]);

            var result = ImagesClient.Delete(resourceGroupName, imageName);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateImageDeleteParameters()
        {
            string resourceGroupName = string.Empty;
            string imageName = string.Empty;

            return ConvertFromObjectsToArguments(
                 new string[] { "ResourceGroupName", "ImageName" },
                 new object[] { resourceGroupName, imageName });
        }
    }

    [Cmdlet(VerbsCommon.Remove, "AzureRmImage", DefaultParameterSetName = "InvokeByDynamicParameters", SupportsShouldProcess = true)]
    public partial class RemoveAzureRmImage : InvokeAzureComputeMethodCmdlet
    {
        public override string MethodName { get; set; }

        protected override void ProcessRecord()
        {
            this.MethodName = "ImageDelete";
            if (ShouldProcess(this.dynamicParameters["ResourceGroupName"].Value.ToString(), VerbsCommon.Remove)
                && (this.dynamicParameters["Force"].IsSet ||
                    this.ShouldContinue(Properties.Resources.ResourceRemovalConfirmation,
                                        "Remove-AzureRmImage operation")))
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
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pImageName = new RuntimeDefinedParameter();
            pImageName.Name = "ImageName";
            pImageName.ParameterType = typeof(string);
            pImageName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = false
            });
            pImageName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ImageName", pImageName);

            var pForce = new RuntimeDefinedParameter();
            pForce.Name = "Force";
            pForce.ParameterType = typeof(SwitchParameter);
            pForce.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = false
            });
            pForce.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Force", pForce);

            return dynamicParameters;
        }
    }
}
