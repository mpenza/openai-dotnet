// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionStreamResponseUsage : IJsonModel<InternalCreateChatCompletionStreamResponseUsage>
    {
        internal InternalCreateChatCompletionStreamResponseUsage()
        {
        }

        void IJsonModel<InternalCreateChatCompletionStreamResponseUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionStreamResponseUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionStreamResponseUsage)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("completion_tokens") != true)
            {
                writer.WritePropertyName("completion_tokens"u8);
                writer.WriteNumberValue(CompletionTokens);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("prompt_tokens") != true)
            {
                writer.WritePropertyName("prompt_tokens"u8);
                writer.WriteNumberValue(PromptTokens);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("total_tokens") != true)
            {
                writer.WritePropertyName("total_tokens"u8);
                writer.WriteNumberValue(TotalTokens);
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

        InternalCreateChatCompletionStreamResponseUsage IJsonModel<InternalCreateChatCompletionStreamResponseUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalCreateChatCompletionStreamResponseUsage JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionStreamResponseUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionStreamResponseUsage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateChatCompletionStreamResponseUsage(document.RootElement, options);
        }

        internal static InternalCreateChatCompletionStreamResponseUsage DeserializeInternalCreateChatCompletionStreamResponseUsage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int completionTokens = default;
            int promptTokens = default;
            int totalTokens = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("completion_tokens"u8))
                {
                    completionTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("prompt_tokens"u8))
                {
                    promptTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("total_tokens"u8))
                {
                    totalTokens = prop.Value.GetInt32();
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalCreateChatCompletionStreamResponseUsage(completionTokens, promptTokens, totalTokens, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalCreateChatCompletionStreamResponseUsage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionStreamResponseUsage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionStreamResponseUsage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateChatCompletionStreamResponseUsage IPersistableModel<InternalCreateChatCompletionStreamResponseUsage>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalCreateChatCompletionStreamResponseUsage PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionStreamResponseUsage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalCreateChatCompletionStreamResponseUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionStreamResponseUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateChatCompletionStreamResponseUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalCreateChatCompletionStreamResponseUsage internalCreateChatCompletionStreamResponseUsage)
        {
            if (internalCreateChatCompletionStreamResponseUsage == null)
            {
                return null;
            }
            return BinaryContent.Create(internalCreateChatCompletionStreamResponseUsage, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalCreateChatCompletionStreamResponseUsage(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateChatCompletionStreamResponseUsage(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
