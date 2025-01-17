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
    internal partial class InternalCreateChatCompletionFunctionResponseChoice : IJsonModel<InternalCreateChatCompletionFunctionResponseChoice>
    {
        internal InternalCreateChatCompletionFunctionResponseChoice()
        {
        }

        void IJsonModel<InternalCreateChatCompletionFunctionResponseChoice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("finish_reason") != true)
            {
                writer.WritePropertyName("finish_reason"u8);
                writer.WriteStringValue(FinishReason.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("index") != true)
            {
                writer.WritePropertyName("index"u8);
                writer.WriteNumberValue(Index);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("message") != true)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteObjectValue(Message, options);
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

        InternalCreateChatCompletionFunctionResponseChoice IJsonModel<InternalCreateChatCompletionFunctionResponseChoice>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalCreateChatCompletionFunctionResponseChoice JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateChatCompletionFunctionResponseChoice(document.RootElement, options);
        }

        internal static InternalCreateChatCompletionFunctionResponseChoice DeserializeInternalCreateChatCompletionFunctionResponseChoice(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalCreateChatCompletionFunctionResponseChoiceFinishReason finishReason = default;
            int index = default;
            InternalChatCompletionResponseMessage message = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("finish_reason"u8))
                {
                    finishReason = new InternalCreateChatCompletionFunctionResponseChoiceFinishReason(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("index"u8))
                {
                    index = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("message"u8))
                {
                    message = InternalChatCompletionResponseMessage.DeserializeInternalChatCompletionResponseMessage(prop.Value, options);
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalCreateChatCompletionFunctionResponseChoice(finishReason, index, message, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateChatCompletionFunctionResponseChoice IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalCreateChatCompletionFunctionResponseChoice PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalCreateChatCompletionFunctionResponseChoice(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateChatCompletionFunctionResponseChoice)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateChatCompletionFunctionResponseChoice>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalCreateChatCompletionFunctionResponseChoice internalCreateChatCompletionFunctionResponseChoice)
        {
            if (internalCreateChatCompletionFunctionResponseChoice == null)
            {
                return null;
            }
            return BinaryContent.Create(internalCreateChatCompletionFunctionResponseChoice, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalCreateChatCompletionFunctionResponseChoice(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateChatCompletionFunctionResponseChoice(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
