// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The properties of a DigitalTwinsInstance.</summary>
    public partial class DigitalTwinsPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IDigitalTwinsPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IDigitalTwinsPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? _publicNetworkAccess;

        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Creates an new <see cref="DigitalTwinsPatchProperties" /> instance.</summary>
        public DigitalTwinsPatchProperties()
        {

        }
    }
    /// The properties of a DigitalTwinsInstance.
    public partial interface IDigitalTwinsPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Public network access for the DigitalTwinsInstance.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }

    }
    /// The properties of a DigitalTwinsInstance.
    internal partial interface IDigitalTwinsPatchPropertiesInternal

    {
        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }

    }
}