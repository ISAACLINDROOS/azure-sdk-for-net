// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary>
    /// DbSystemShape resource model
    /// Serialized Name: DbSystemShapeProperties
    /// </summary>
    public partial class DbSystemShapeProperties
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

        /// <summary> Initializes a new instance of <see cref="DbSystemShapeProperties"/>. </summary>
        /// <param name="availableCoreCount">
        /// The maximum number of CPU cores that can be enabled on the DB system for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableCoreCount
        /// </param>
        public DbSystemShapeProperties(int availableCoreCount)
        {
            AvailableCoreCount = availableCoreCount;
        }

        /// <summary> Initializes a new instance of <see cref="DbSystemShapeProperties"/>. </summary>
        /// <param name="shapeFamily">
        /// The family of the shape used for the DB system.
        /// Serialized Name: DbSystemShapeProperties.shapeFamily
        /// </param>
        /// <param name="availableCoreCount">
        /// The maximum number of CPU cores that can be enabled on the DB system for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableCoreCount
        /// </param>
        /// <param name="minimumCoreCount">
        /// The minimum number of CPU cores that can be enabled on the DB system for this shape.
        /// Serialized Name: DbSystemShapeProperties.minimumCoreCount
        /// </param>
        /// <param name="runtimeMinimumCoreCount">
        /// The runtime minimum number of CPU cores that can be enabled on the DB system for this shape.
        /// Serialized Name: DbSystemShapeProperties.runtimeMinimumCoreCount
        /// </param>
        /// <param name="coreCountIncrement">
        /// The discrete number by which the CPU core count for this shape can be increased or decreased.
        /// Serialized Name: DbSystemShapeProperties.coreCountIncrement
        /// </param>
        /// <param name="minStorageCount">
        /// The minimum number of Exadata storage servers available for the Exadata infrastructure.
        /// Serialized Name: DbSystemShapeProperties.minStorageCount
        /// </param>
        /// <param name="maxStorageCount">
        /// The maximum number of Exadata storage servers available for the Exadata infrastructure.
        /// Serialized Name: DbSystemShapeProperties.maxStorageCount
        /// </param>
        /// <param name="availableDataStoragePerServerInTbs">
        /// The maximum data storage available per storage server for this shape. Only applicable to ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableDataStoragePerServerInTbs
        /// </param>
        /// <param name="availableMemoryPerNodeInGbs">
        /// The maximum memory available per database node for this shape. Only applicable to ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableMemoryPerNodeInGbs
        /// </param>
        /// <param name="availableDbNodePerNodeInGbs">
        /// The maximum Db Node storage available per database node for this shape. Only applicable to ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableDbNodePerNodeInGbs
        /// </param>
        /// <param name="minCoreCountPerNode">
        /// The minimum number of CPU cores that can be enabled per node for this shape.
        /// Serialized Name: DbSystemShapeProperties.minCoreCountPerNode
        /// </param>
        /// <param name="availableMemoryInGbs">
        /// The maximum memory that can be enabled for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableMemoryInGbs
        /// </param>
        /// <param name="minMemoryPerNodeInGbs">
        /// The minimum memory that need be allocated per node for this shape.
        /// Serialized Name: DbSystemShapeProperties.minMemoryPerNodeInGbs
        /// </param>
        /// <param name="availableDbNodeStorageInGbs">
        /// The maximum Db Node storage that can be enabled for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableDbNodeStorageInGbs
        /// </param>
        /// <param name="minDbNodeStoragePerNodeInGbs">
        /// The minimum Db Node storage that need be allocated per node for this shape.
        /// Serialized Name: DbSystemShapeProperties.minDbNodeStoragePerNodeInGbs
        /// </param>
        /// <param name="availableDataStorageInTbs">
        /// The maximum DATA storage that can be enabled for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableDataStorageInTbs
        /// </param>
        /// <param name="minDataStorageInTbs">
        /// The minimum data storage that need be allocated for this shape.
        /// Serialized Name: DbSystemShapeProperties.minDataStorageInTbs
        /// </param>
        /// <param name="minimumNodeCount">
        /// The minimum number of database nodes available for this shape.
        /// Serialized Name: DbSystemShapeProperties.minimumNodeCount
        /// </param>
        /// <param name="maximumNodeCount">
        /// The maximum number of database nodes available for this shape.
        /// Serialized Name: DbSystemShapeProperties.maximumNodeCount
        /// </param>
        /// <param name="availableCoreCountPerNode">
        /// The maximum number of CPU cores per database node that can be enabled for this shape. Only applicable to the flex Exadata shape and ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableCoreCountPerNode
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DbSystemShapeProperties(string shapeFamily, int availableCoreCount, int? minimumCoreCount, int? runtimeMinimumCoreCount, int? coreCountIncrement, int? minStorageCount, int? maxStorageCount, double? availableDataStoragePerServerInTbs, int? availableMemoryPerNodeInGbs, int? availableDbNodePerNodeInGbs, int? minCoreCountPerNode, int? availableMemoryInGbs, int? minMemoryPerNodeInGbs, int? availableDbNodeStorageInGbs, int? minDbNodeStoragePerNodeInGbs, int? availableDataStorageInTbs, int? minDataStorageInTbs, int? minimumNodeCount, int? maximumNodeCount, int? availableCoreCountPerNode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ShapeFamily = shapeFamily;
            AvailableCoreCount = availableCoreCount;
            MinimumCoreCount = minimumCoreCount;
            RuntimeMinimumCoreCount = runtimeMinimumCoreCount;
            CoreCountIncrement = coreCountIncrement;
            MinStorageCount = minStorageCount;
            MaxStorageCount = maxStorageCount;
            AvailableDataStoragePerServerInTbs = availableDataStoragePerServerInTbs;
            AvailableMemoryPerNodeInGbs = availableMemoryPerNodeInGbs;
            AvailableDbNodePerNodeInGbs = availableDbNodePerNodeInGbs;
            MinCoreCountPerNode = minCoreCountPerNode;
            AvailableMemoryInGbs = availableMemoryInGbs;
            MinMemoryPerNodeInGbs = minMemoryPerNodeInGbs;
            AvailableDbNodeStorageInGbs = availableDbNodeStorageInGbs;
            MinDbNodeStoragePerNodeInGbs = minDbNodeStoragePerNodeInGbs;
            AvailableDataStorageInTbs = availableDataStorageInTbs;
            MinDataStorageInTbs = minDataStorageInTbs;
            MinimumNodeCount = minimumNodeCount;
            MaximumNodeCount = maximumNodeCount;
            AvailableCoreCountPerNode = availableCoreCountPerNode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DbSystemShapeProperties"/> for deserialization. </summary>
        internal DbSystemShapeProperties()
        {
        }

        /// <summary>
        /// The family of the shape used for the DB system.
        /// Serialized Name: DbSystemShapeProperties.shapeFamily
        /// </summary>
        public string ShapeFamily { get; }
        /// <summary>
        /// The maximum number of CPU cores that can be enabled on the DB system for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableCoreCount
        /// </summary>
        public int AvailableCoreCount { get; }
        /// <summary>
        /// The minimum number of CPU cores that can be enabled on the DB system for this shape.
        /// Serialized Name: DbSystemShapeProperties.minimumCoreCount
        /// </summary>
        public int? MinimumCoreCount { get; }
        /// <summary>
        /// The runtime minimum number of CPU cores that can be enabled on the DB system for this shape.
        /// Serialized Name: DbSystemShapeProperties.runtimeMinimumCoreCount
        /// </summary>
        public int? RuntimeMinimumCoreCount { get; }
        /// <summary>
        /// The discrete number by which the CPU core count for this shape can be increased or decreased.
        /// Serialized Name: DbSystemShapeProperties.coreCountIncrement
        /// </summary>
        public int? CoreCountIncrement { get; }
        /// <summary>
        /// The minimum number of Exadata storage servers available for the Exadata infrastructure.
        /// Serialized Name: DbSystemShapeProperties.minStorageCount
        /// </summary>
        public int? MinStorageCount { get; }
        /// <summary>
        /// The maximum number of Exadata storage servers available for the Exadata infrastructure.
        /// Serialized Name: DbSystemShapeProperties.maxStorageCount
        /// </summary>
        public int? MaxStorageCount { get; }
        /// <summary>
        /// The maximum data storage available per storage server for this shape. Only applicable to ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableDataStoragePerServerInTbs
        /// </summary>
        public double? AvailableDataStoragePerServerInTbs { get; }
        /// <summary>
        /// The maximum memory available per database node for this shape. Only applicable to ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableMemoryPerNodeInGbs
        /// </summary>
        public int? AvailableMemoryPerNodeInGbs { get; }
        /// <summary>
        /// The maximum Db Node storage available per database node for this shape. Only applicable to ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableDbNodePerNodeInGbs
        /// </summary>
        public int? AvailableDbNodePerNodeInGbs { get; }
        /// <summary>
        /// The minimum number of CPU cores that can be enabled per node for this shape.
        /// Serialized Name: DbSystemShapeProperties.minCoreCountPerNode
        /// </summary>
        public int? MinCoreCountPerNode { get; }
        /// <summary>
        /// The maximum memory that can be enabled for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableMemoryInGbs
        /// </summary>
        public int? AvailableMemoryInGbs { get; }
        /// <summary>
        /// The minimum memory that need be allocated per node for this shape.
        /// Serialized Name: DbSystemShapeProperties.minMemoryPerNodeInGbs
        /// </summary>
        public int? MinMemoryPerNodeInGbs { get; }
        /// <summary>
        /// The maximum Db Node storage that can be enabled for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableDbNodeStorageInGbs
        /// </summary>
        public int? AvailableDbNodeStorageInGbs { get; }
        /// <summary>
        /// The minimum Db Node storage that need be allocated per node for this shape.
        /// Serialized Name: DbSystemShapeProperties.minDbNodeStoragePerNodeInGbs
        /// </summary>
        public int? MinDbNodeStoragePerNodeInGbs { get; }
        /// <summary>
        /// The maximum DATA storage that can be enabled for this shape.
        /// Serialized Name: DbSystemShapeProperties.availableDataStorageInTbs
        /// </summary>
        public int? AvailableDataStorageInTbs { get; }
        /// <summary>
        /// The minimum data storage that need be allocated for this shape.
        /// Serialized Name: DbSystemShapeProperties.minDataStorageInTbs
        /// </summary>
        public int? MinDataStorageInTbs { get; }
        /// <summary>
        /// The minimum number of database nodes available for this shape.
        /// Serialized Name: DbSystemShapeProperties.minimumNodeCount
        /// </summary>
        public int? MinimumNodeCount { get; }
        /// <summary>
        /// The maximum number of database nodes available for this shape.
        /// Serialized Name: DbSystemShapeProperties.maximumNodeCount
        /// </summary>
        public int? MaximumNodeCount { get; }
        /// <summary>
        /// The maximum number of CPU cores per database node that can be enabled for this shape. Only applicable to the flex Exadata shape and ExaCC Elastic shapes.
        /// Serialized Name: DbSystemShapeProperties.availableCoreCountPerNode
        /// </summary>
        public int? AvailableCoreCountPerNode { get; }
    }
}
