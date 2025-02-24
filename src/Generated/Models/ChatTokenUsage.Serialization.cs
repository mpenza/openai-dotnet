// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    public partial class ChatTokenUsage : IJsonModel<ChatTokenUsage>
    {
        void IJsonModel<ChatTokenUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("completion_tokens") != true)
            {
                writer.WritePropertyName("completion_tokens"u8);
                writer.WriteNumberValue(OutputTokenCount);
            }
            if (SerializedAdditionalRawData?.ContainsKey("prompt_tokens") != true)
            {
                writer.WritePropertyName("prompt_tokens"u8);
                writer.WriteNumberValue(InputTokenCount);
            }
            if (SerializedAdditionalRawData?.ContainsKey("total_tokens") != true)
            {
                writer.WritePropertyName("total_tokens"u8);
                writer.WriteNumberValue(TotalTokenCount);
            }
            if (SerializedAdditionalRawData?.ContainsKey("completion_tokens_details") != true && Optional.IsDefined(OutputTokenDetails))
            {
                writer.WritePropertyName("completion_tokens_details"u8);
                writer.WriteObjectValue<ChatOutputTokenUsageDetails>(OutputTokenDetails, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("prompt_tokens_details") != true && Optional.IsDefined(InputTokenDetails))
            {
                writer.WritePropertyName("prompt_tokens_details"u8);
                writer.WriteObjectValue<ChatInputTokenUsageDetails>(InputTokenDetails, options);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
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
            writer.WriteEndObject();
        }

        ChatTokenUsage IJsonModel<ChatTokenUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatTokenUsage(document.RootElement, options);
        }

        internal static ChatTokenUsage DeserializeChatTokenUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int completionTokens = default;
            int promptTokens = default;
            int totalTokens = default;
            ChatOutputTokenUsageDetails completionTokensDetails = default;
            ChatInputTokenUsageDetails promptTokensDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completion_tokens"u8))
                {
                    completionTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("prompt_tokens"u8))
                {
                    promptTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total_tokens"u8))
                {
                    totalTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("completion_tokens_details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completionTokensDetails = ChatOutputTokenUsageDetails.DeserializeChatOutputTokenUsageDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("prompt_tokens_details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    promptTokensDetails = ChatInputTokenUsageDetails.DeserializeChatInputTokenUsageDetails(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChatTokenUsage(
                completionTokens,
                promptTokens,
                totalTokens,
                completionTokensDetails,
                promptTokensDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatTokenUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support writing '{options.Format}' format.");
            }
        }

        ChatTokenUsage IPersistableModel<ChatTokenUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatTokenUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatTokenUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static ChatTokenUsage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatTokenUsage(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
