// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Unknown version of ScheduleAvailabilityRequest. </summary>
    internal partial class UnknownScheduleAvailabilityRequest : ScheduleAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownScheduleAvailabilityRequest"/>. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="skuName"> Sku Name for which the order is to be scheduled. </param>
        /// <param name="country"> Country in which storage location should be supported. </param>
        /// <param name="model"> The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownScheduleAvailabilityRequest(AzureLocation storageLocation, DataBoxSkuName skuName, string country, DeviceModelName? model, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(storageLocation, skuName, country, model, serializedAdditionalRawData)
        {
            SkuName = skuName;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownScheduleAvailabilityRequest"/> for deserialization. </summary>
        internal UnknownScheduleAvailabilityRequest()
        {
        }
    }
}
