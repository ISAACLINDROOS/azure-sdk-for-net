// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The ComputeSubResourceDataWithColocationStatus. </summary>
    public partial class ComputeSubResourceDataWithColocationStatus : ComputeWriteableSubResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ComputeSubResourceDataWithColocationStatus"/>. </summary>
        public ComputeSubResourceDataWithColocationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeSubResourceDataWithColocationStatus"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="colocationStatus"> Describes colocation status of a resource in the Proximity Placement Group. </param>
        internal ComputeSubResourceDataWithColocationStatus(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData, InstanceViewStatus colocationStatus) : base(id, serializedAdditionalRawData)
        {
            ColocationStatus = colocationStatus;
        }

        /// <summary> Describes colocation status of a resource in the Proximity Placement Group. </summary>
        public InstanceViewStatus ColocationStatus { get; set; }
    }
}
