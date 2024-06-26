// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network security rules evaluation result. </summary>
    public partial class NetworkSecurityRulesEvaluationResult
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

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityRulesEvaluationResult"/>. </summary>
        internal NetworkSecurityRulesEvaluationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityRulesEvaluationResult"/>. </summary>
        /// <param name="name"> Name of the network security rule. </param>
        /// <param name="protocolMatched"> Value indicating whether protocol is matched. </param>
        /// <param name="sourceMatched"> Value indicating whether source is matched. </param>
        /// <param name="sourcePortMatched"> Value indicating whether source port is matched. </param>
        /// <param name="destinationMatched"> Value indicating whether destination is matched. </param>
        /// <param name="destinationPortMatched"> Value indicating whether destination port is matched. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityRulesEvaluationResult(string name, bool? protocolMatched, bool? sourceMatched, bool? sourcePortMatched, bool? destinationMatched, bool? destinationPortMatched, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ProtocolMatched = protocolMatched;
            SourceMatched = sourceMatched;
            SourcePortMatched = sourcePortMatched;
            DestinationMatched = destinationMatched;
            DestinationPortMatched = destinationPortMatched;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the network security rule. </summary>
        public string Name { get; }
        /// <summary> Value indicating whether protocol is matched. </summary>
        public bool? ProtocolMatched { get; }
        /// <summary> Value indicating whether source is matched. </summary>
        public bool? SourceMatched { get; }
        /// <summary> Value indicating whether source port is matched. </summary>
        public bool? SourcePortMatched { get; }
        /// <summary> Value indicating whether destination is matched. </summary>
        public bool? DestinationMatched { get; }
        /// <summary> Value indicating whether destination port is matched. </summary>
        public bool? DestinationPortMatched { get; }
    }
}
