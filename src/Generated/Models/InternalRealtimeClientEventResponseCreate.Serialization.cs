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
    internal partial class InternalRealtimeClientEventResponseCreate : IJsonModel<InternalRealtimeClientEventResponseCreate>
    {
        void IJsonModel<InternalRealtimeClientEventResponseCreate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventResponseCreate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeClientEventResponseCreate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Response) && _additionalBinaryDataProperties?.ContainsKey("response") != true)
            {
                writer.WritePropertyName("response"u8);
                writer.WriteObjectValue(Response, options);
            }
        }

        InternalRealtimeClientEventResponseCreate IJsonModel<InternalRealtimeClientEventResponseCreate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeClientEventResponseCreate)JsonModelCreateCore(ref reader, options);

        protected override InternalRealtimeClientEvent JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventResponseCreate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeClientEventResponseCreate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeClientEventResponseCreate(document.RootElement, options);
        }

        internal static InternalRealtimeClientEventResponseCreate DeserializeInternalRealtimeClientEventResponseCreate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeClientEventType kind = default;
            string eventId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            ConversationResponseOptions response = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalRealtimeClientEventType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("response"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = ConversationResponseOptions.DeserializeConversationResponseOptions(prop.Value, options);
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalRealtimeClientEventResponseCreate(kind, eventId, additionalBinaryDataProperties, response);
        }

        BinaryData IPersistableModel<InternalRealtimeClientEventResponseCreate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventResponseCreate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeClientEventResponseCreate)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeClientEventResponseCreate IPersistableModel<InternalRealtimeClientEventResponseCreate>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeClientEventResponseCreate)PersistableModelCreateCore(data, options);

        protected override InternalRealtimeClientEvent PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventResponseCreate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeClientEventResponseCreate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeClientEventResponseCreate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeClientEventResponseCreate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRealtimeClientEventResponseCreate internalRealtimeClientEventResponseCreate)
        {
            if (internalRealtimeClientEventResponseCreate == null)
            {
                return null;
            }
            return BinaryContent.Create(internalRealtimeClientEventResponseCreate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRealtimeClientEventResponseCreate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRealtimeClientEventResponseCreate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
