// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request to validate create order limit for current subscription. </summary>
    public partial class CreateOrderLimitForSubscriptionValidationContent : DataBoxValidationInputContent
    {
        /// <summary> Initializes a new instance of <see cref="CreateOrderLimitForSubscriptionValidationContent"/>. </summary>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        public CreateOrderLimitForSubscriptionValidationContent(DataBoxSkuName deviceType)
        {
            DeviceType = deviceType;
            ValidationType = DataBoxValidationInputDiscriminator.ValidateCreateOrderLimit;
        }

        /// <summary> Initializes a new instance of <see cref="CreateOrderLimitForSubscriptionValidationContent"/>. </summary>
        /// <param name="validationType"> Identifies the type of validation request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        /// <param name="model"> The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025. </param>
        internal CreateOrderLimitForSubscriptionValidationContent(DataBoxValidationInputDiscriminator validationType, IDictionary<string, BinaryData> serializedAdditionalRawData, DataBoxSkuName deviceType, DeviceModelName? model) : base(validationType, serializedAdditionalRawData)
        {
            DeviceType = deviceType;
            Model = model;
            ValidationType = validationType;
        }

        /// <summary> Initializes a new instance of <see cref="CreateOrderLimitForSubscriptionValidationContent"/> for deserialization. </summary>
        internal CreateOrderLimitForSubscriptionValidationContent()
        {
        }

        /// <summary> Device type to be used for the job. </summary>
        public DataBoxSkuName DeviceType { get; }
        /// <summary> The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025. </summary>
        public DeviceModelName? Model { get; set; }
    }
}
