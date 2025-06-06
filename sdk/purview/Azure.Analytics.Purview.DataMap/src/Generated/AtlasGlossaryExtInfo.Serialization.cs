// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasGlossaryExtInfo : IUtf8JsonSerializable, IJsonModel<AtlasGlossaryExtInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasGlossaryExtInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtlasGlossaryExtInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryExtInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasGlossaryExtInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Guid))
            {
                writer.WritePropertyName("guid"u8);
                writer.WriteStringValue(Guid);
            }
            if (Optional.IsCollectionDefined(Classifications))
            {
                writer.WritePropertyName("classifications"u8);
                writer.WriteStartArray();
                foreach (var item in Classifications)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LongDescription))
            {
                writer.WritePropertyName("longDescription"u8);
                writer.WriteStringValue(LongDescription);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(QualifiedName))
            {
                writer.WritePropertyName("qualifiedName"u8);
                writer.WriteStringValue(QualifiedName);
            }
            if (Optional.IsDefined(ShortDescription))
            {
                writer.WritePropertyName("shortDescription"u8);
                writer.WriteStringValue(ShortDescription);
            }
            if (Optional.IsDefined(LastModifiedTS))
            {
                writer.WritePropertyName("lastModifiedTS"u8);
                writer.WriteStringValue(LastModifiedTS);
            }
            if (Optional.IsDefined(CreateTime))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteNumberValue(CreateTime.Value);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(UpdateTime))
            {
                writer.WritePropertyName("updateTime"u8);
                writer.WriteNumberValue(UpdateTime.Value);
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteStringValue(UpdatedBy);
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsCollectionDefined(Terms))
            {
                writer.WritePropertyName("terms"u8);
                writer.WriteStartArray();
                foreach (var item in Terms)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteStringValue(Usage);
            }
            if (Optional.IsCollectionDefined(CategoryInfo))
            {
                writer.WritePropertyName("categoryInfo"u8);
                writer.WriteStartObject();
                foreach (var item in CategoryInfo)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TermInfo))
            {
                writer.WritePropertyName("termInfo"u8);
                writer.WriteStartObject();
                foreach (var item in TermInfo)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        AtlasGlossaryExtInfo IJsonModel<AtlasGlossaryExtInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryExtInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasGlossaryExtInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasGlossaryExtInfo(document.RootElement, options);
        }

        internal static AtlasGlossaryExtInfo DeserializeAtlasGlossaryExtInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string guid = default;
            IReadOnlyList<AtlasClassification> classifications = default;
            string longDescription = default;
            string name = default;
            string qualifiedName = default;
            string shortDescription = default;
            string lastModifiedTS = default;
            long? createTime = default;
            string createdBy = default;
            long? updateTime = default;
            string updatedBy = default;
            IReadOnlyList<AtlasRelatedCategoryHeader> categories = default;
            string language = default;
            IReadOnlyList<AtlasRelatedTermHeader> terms = default;
            string usage = default;
            IReadOnlyDictionary<string, AtlasGlossaryCategory> categoryInfo = default;
            IReadOnlyDictionary<string, AtlasGlossaryTerm> termInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("guid"u8))
                {
                    guid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasClassification> array = new List<AtlasClassification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasClassification.DeserializeAtlasClassification(item, options));
                    }
                    classifications = array;
                    continue;
                }
                if (property.NameEquals("longDescription"u8))
                {
                    longDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shortDescription"u8))
                {
                    shortDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedTS"u8))
                {
                    lastModifiedTS = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("updatedBy"u8))
                {
                    updatedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasRelatedCategoryHeader> array = new List<AtlasRelatedCategoryHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasRelatedCategoryHeader.DeserializeAtlasRelatedCategoryHeader(item, options));
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("terms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasRelatedTermHeader> array = new List<AtlasRelatedTermHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasRelatedTermHeader.DeserializeAtlasRelatedTermHeader(item, options));
                    }
                    terms = array;
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    usage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categoryInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, AtlasGlossaryCategory> dictionary = new Dictionary<string, AtlasGlossaryCategory>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, AtlasGlossaryCategory.DeserializeAtlasGlossaryCategory(property0.Value, options));
                    }
                    categoryInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("termInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, AtlasGlossaryTerm> dictionary = new Dictionary<string, AtlasGlossaryTerm>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, AtlasGlossaryTerm.DeserializeAtlasGlossaryTerm(property0.Value, options));
                    }
                    termInfo = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AtlasGlossaryExtInfo(
                guid,
                classifications ?? new ChangeTrackingList<AtlasClassification>(),
                longDescription,
                name,
                qualifiedName,
                shortDescription,
                lastModifiedTS,
                createTime,
                createdBy,
                updateTime,
                updatedBy,
                categories ?? new ChangeTrackingList<AtlasRelatedCategoryHeader>(),
                language,
                terms ?? new ChangeTrackingList<AtlasRelatedTermHeader>(),
                usage,
                categoryInfo ?? new ChangeTrackingDictionary<string, AtlasGlossaryCategory>(),
                termInfo ?? new ChangeTrackingDictionary<string, AtlasGlossaryTerm>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasGlossaryExtInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryExtInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasGlossaryExtInfo)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasGlossaryExtInfo IPersistableModel<AtlasGlossaryExtInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasGlossaryExtInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAtlasGlossaryExtInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasGlossaryExtInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasGlossaryExtInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasGlossaryExtInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAtlasGlossaryExtInfo(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
