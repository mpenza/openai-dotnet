// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Embeddings
{
    public partial class EmbeddingGenerationOptions : IJsonModel<EmbeddingGenerationOptions>
    {
        void IJsonModel<EmbeddingGenerationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmbeddingGenerationOptions)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Dimensions) && _additionalBinaryDataProperties?.ContainsKey("dimensions") != true)
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteNumberValue(Dimensions.Value);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("input") != true)
            {
                writer.WritePropertyName("input"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(Input);
#else
                using (JsonDocument document = JsonDocument.Parse(Input))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (_additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model.ToString());
            }
            if (Optional.IsDefined(EncodingFormat) && _additionalBinaryDataProperties?.ContainsKey("encoding_format") != true)
            {
                writer.WritePropertyName("encoding_format"u8);
                writer.WriteStringValue(EncodingFormat.Value.ToString());
            }
            if (Optional.IsDefined(EndUserId) && _additionalBinaryDataProperties?.ContainsKey("user") != true)
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(EndUserId);
            }
            if (true && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        EmbeddingGenerationOptions IJsonModel<EmbeddingGenerationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual EmbeddingGenerationOptions JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmbeddingGenerationOptions)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEmbeddingGenerationOptions(document.RootElement, options);
        }

        internal static EmbeddingGenerationOptions DeserializeEmbeddingGenerationOptions(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? dimensions = default;
            BinaryData input = default;
            InternalCreateEmbeddingRequestModel model = default;
            InternalCreateEmbeddingRequestEncodingFormat? encodingFormat = default;
            string endUserId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("dimensions"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dimensions = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("input"u8))
                {
                    input = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                if (prop.NameEquals("model"u8))
                {
                    model = new InternalCreateEmbeddingRequestModel(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("encoding_format"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encodingFormat = new InternalCreateEmbeddingRequestEncodingFormat(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("user"u8))
                {
                    endUserId = prop.Value.GetString();
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new EmbeddingGenerationOptions(
                dimensions,
                input,
                model,
                encodingFormat,
                endUserId,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<EmbeddingGenerationOptions>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EmbeddingGenerationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        EmbeddingGenerationOptions IPersistableModel<EmbeddingGenerationOptions>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual EmbeddingGenerationOptions PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeEmbeddingGenerationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EmbeddingGenerationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EmbeddingGenerationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(EmbeddingGenerationOptions embeddingGenerationOptions)
        {
            if (embeddingGenerationOptions == null)
            {
                return null;
            }
            return BinaryContent.Create(embeddingGenerationOptions, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator EmbeddingGenerationOptions(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeEmbeddingGenerationOptions(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
