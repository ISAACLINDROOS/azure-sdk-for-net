// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterIdentityResult : IUtf8JsonSerializable, IJsonModel<HciClusterIdentityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciClusterIdentityResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciClusterIdentityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId"u8);
                writer.WriteStringValue(AadClientId.Value);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(AadServicePrincipalObjectId))
            {
                writer.WritePropertyName("aadServicePrincipalObjectId"u8);
                writer.WriteStringValue(AadServicePrincipalObjectId.Value);
            }
            if (Optional.IsDefined(AadApplicationObjectId))
            {
                writer.WritePropertyName("aadApplicationObjectId"u8);
                writer.WriteStringValue(AadApplicationObjectId.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        HciClusterIdentityResult IJsonModel<HciClusterIdentityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterIdentityResult(document.RootElement, options);
        }

        internal static HciClusterIdentityResult DeserializeHciClusterIdentityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? aadClientId = default;
            Guid? aadTenantId = default;
            Guid? aadServicePrincipalObjectId = default;
            Guid? aadApplicationObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("aadClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadServicePrincipalObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadApplicationObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HciClusterIdentityResult(aadClientId, aadTenantId, aadServicePrincipalObjectId, aadApplicationObjectId, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AadClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aadClientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AadClientId))
                {
                    builder.Append("    aadClientId: ");
                    builder.AppendLine($"'{AadClientId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AadTenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aadTenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AadTenantId))
                {
                    builder.Append("    aadTenantId: ");
                    builder.AppendLine($"'{AadTenantId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AadServicePrincipalObjectId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aadServicePrincipalObjectId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AadServicePrincipalObjectId))
                {
                    builder.Append("    aadServicePrincipalObjectId: ");
                    builder.AppendLine($"'{AadServicePrincipalObjectId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AadApplicationObjectId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aadApplicationObjectId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AadApplicationObjectId))
                {
                    builder.Append("    aadApplicationObjectId: ");
                    builder.AppendLine($"'{AadApplicationObjectId.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HciClusterIdentityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support writing '{options.Format}' format.");
            }
        }

        HciClusterIdentityResult IPersistableModel<HciClusterIdentityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHciClusterIdentityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciClusterIdentityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
