// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure CosmosDB (SQL API) Collection source. </summary>
    public partial class CosmosDbSqlApiSource : CopySource
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDbSqlApiSource"/>. </summary>
        public CosmosDbSqlApiSource()
        {
            Type = "CosmosDbSqlApiSource";
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDbSqlApiSource"/>. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> SQL API query. Type: string (or Expression with resultType string). </param>
        /// <param name="pageSize"> Page size of the result. Type: integer (or Expression with resultType integer). </param>
        /// <param name="preferredRegions"> Preferred regions. Type: array of strings (or Expression with resultType array of strings). </param>
        /// <param name="detectDatetime"> Whether detect primitive values as datetime values. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal CosmosDbSqlApiSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object query, object pageSize, object preferredRegions, object detectDatetime, object additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            Query = query;
            PageSize = pageSize;
            PreferredRegions = preferredRegions;
            DetectDatetime = detectDatetime;
            AdditionalColumns = additionalColumns;
            Type = type ?? "CosmosDbSqlApiSource";
        }

        /// <summary> SQL API query. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> Page size of the result. Type: integer (or Expression with resultType integer). </summary>
        public object PageSize { get; set; }
        /// <summary> Preferred regions. Type: array of strings (or Expression with resultType array of strings). </summary>
        public object PreferredRegions { get; set; }
        /// <summary> Whether detect primitive values as datetime values. Type: boolean (or Expression with resultType boolean). </summary>
        public object DetectDatetime { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public object AdditionalColumns { get; set; }
    }
}
