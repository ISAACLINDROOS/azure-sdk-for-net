// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxHeavySecret : IUtf8JsonSerializable, IJsonModel<DataBoxHeavySecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxHeavySecret>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxHeavySecret>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavySecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxHeavySecret)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(DeviceSerialNumber))
            {
                writer.WritePropertyName("deviceSerialNumber"u8);
                writer.WriteStringValue(DeviceSerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(DevicePassword))
            {
                writer.WritePropertyName("devicePassword"u8);
                writer.WriteStringValue(DevicePassword);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkConfigurations))
            {
                writer.WritePropertyName("networkConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(EncodedValidationCertPubKey))
            {
                writer.WritePropertyName("encodedValidationCertPubKey"u8);
                writer.WriteStringValue(EncodedValidationCertPubKey);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AccountCredentialDetails))
            {
                writer.WritePropertyName("accountCredentialDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AccountCredentialDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
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

        DataBoxHeavySecret IJsonModel<DataBoxHeavySecret>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavySecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxHeavySecret)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxHeavySecret(document.RootElement, options);
        }

        internal static DataBoxHeavySecret DeserializeDataBoxHeavySecret(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deviceSerialNumber = default;
            string devicePassword = default;
            IReadOnlyList<ApplianceNetworkConfiguration> networkConfigurations = default;
            string encodedValidationCertPubKey = default;
            IReadOnlyList<DataBoxAccountCredentialDetails> accountCredentialDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceSerialNumber"u8))
                {
                    deviceSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplianceNetworkConfiguration> array = new List<ApplianceNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplianceNetworkConfiguration.DeserializeApplianceNetworkConfiguration(item, options));
                    }
                    networkConfigurations = array;
                    continue;
                }
                if (property.NameEquals("encodedValidationCertPubKey"u8))
                {
                    encodedValidationCertPubKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountCredentialDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxAccountCredentialDetails> array = new List<DataBoxAccountCredentialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxAccountCredentialDetails.DeserializeDataBoxAccountCredentialDetails(item, options));
                    }
                    accountCredentialDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxHeavySecret(
                deviceSerialNumber,
                devicePassword,
                networkConfigurations ?? new ChangeTrackingList<ApplianceNetworkConfiguration>(),
                encodedValidationCertPubKey,
                accountCredentialDetails ?? new ChangeTrackingList<DataBoxAccountCredentialDetails>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxHeavySecret>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavySecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxHeavySecret)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxHeavySecret IPersistableModel<DataBoxHeavySecret>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxHeavySecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataBoxHeavySecret(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxHeavySecret)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxHeavySecret>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
