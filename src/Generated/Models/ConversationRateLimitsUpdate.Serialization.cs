// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationRateLimitsUpdate : IJsonModel<ConversationRateLimitsUpdate>
    {
        internal ConversationRateLimitsUpdate()
        {
        }

        void IJsonModel<ConversationRateLimitsUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationRateLimitsUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationRateLimitsUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("rate_limits") != true)
            {
                writer.WritePropertyName("rate_limits"u8);
                writer.WriteStartArray();
                foreach (ConversationRateLimitDetailsItem item in AllDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        ConversationRateLimitsUpdate IJsonModel<ConversationRateLimitsUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (ConversationRateLimitsUpdate)JsonModelCreateCore(ref reader, options);

        protected override ConversationUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationRateLimitsUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationRateLimitsUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationRateLimitsUpdate(document.RootElement, options);
        }

        internal static ConversationRateLimitsUpdate DeserializeConversationRateLimitsUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventId = default;
            RealtimeConversation.ConversationUpdateKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            IReadOnlyList<ConversationRateLimitDetailsItem> allDetails = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToConversationUpdateKind();
                    continue;
                }
                if (prop.NameEquals("rate_limits"u8))
                {
                    List<ConversationRateLimitDetailsItem> array = new List<ConversationRateLimitDetailsItem>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ConversationRateLimitDetailsItem.DeserializeConversationRateLimitDetailsItem(item, options));
                    }
                    allDetails = array;
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ConversationRateLimitsUpdate(eventId, kind, additionalBinaryDataProperties, allDetails);
        }

        BinaryData IPersistableModel<ConversationRateLimitsUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationRateLimitsUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationRateLimitsUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationRateLimitsUpdate IPersistableModel<ConversationRateLimitsUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (ConversationRateLimitsUpdate)PersistableModelCreateCore(data, options);

        protected override ConversationUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationRateLimitsUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationRateLimitsUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationRateLimitsUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationRateLimitsUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ConversationRateLimitsUpdate conversationRateLimitsUpdate)
        {
            if (conversationRateLimitsUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(conversationRateLimitsUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ConversationRateLimitsUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeConversationRateLimitsUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
