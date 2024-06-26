// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The IotSecuritySolutionAnalyticsModelDevicesMetrics. </summary>
    public partial class IotSecuritySolutionAnalyticsModelDevicesMetrics
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

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelDevicesMetrics"/>. </summary>
        internal IotSecuritySolutionAnalyticsModelDevicesMetrics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelDevicesMetrics"/>. </summary>
        /// <param name="date"> Aggregation of IoT Security solution device alert metrics by date. </param>
        /// <param name="devicesMetrics"> Device alert count by severity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecuritySolutionAnalyticsModelDevicesMetrics(DateTimeOffset? date, IotSeverityMetrics devicesMetrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Date = date;
            DevicesMetrics = devicesMetrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> Device alert count by severity. </summary>
        public IotSeverityMetrics DevicesMetrics { get; }
    }
}
