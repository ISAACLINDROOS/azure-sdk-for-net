// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of on demand test probe. </summary>
    public partial class ApplicationGatewayBackendHealthOnDemand
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthOnDemand"/>. </summary>
        internal ApplicationGatewayBackendHealthOnDemand()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthOnDemand"/>. </summary>
        /// <param name="backendAddressPool"> Reference to an ApplicationGatewayBackendAddressPool resource. </param>
        /// <param name="backendHealthHttpSettings"> Application gateway BackendHealthHttp settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayBackendHealthOnDemand(ApplicationGatewayBackendAddressPool backendAddressPool, ApplicationGatewayBackendHealthHttpSettings backendHealthHttpSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackendAddressPool = backendAddressPool;
            BackendHealthHttpSettings = backendHealthHttpSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Reference to an ApplicationGatewayBackendAddressPool resource. </summary>
        public ApplicationGatewayBackendAddressPool BackendAddressPool { get; }
        /// <summary> Application gateway BackendHealthHttp settings. </summary>
        public ApplicationGatewayBackendHealthHttpSettings BackendHealthHttpSettings { get; }
    }
}
