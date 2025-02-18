// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalTodoFineTuneMethod : IJsonModel<InternalTodoFineTuneMethod>
    {
        void IJsonModel<InternalTodoFineTuneMethod>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTodoFineTuneMethod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalTodoFineTuneMethod)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Type) && _additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Supervised) && _additionalBinaryDataProperties?.ContainsKey("supervised") != true)
            {
                writer.WritePropertyName("supervised"u8);
                writer.WriteObjectValue(Supervised, options);
            }
            if (Optional.IsDefined(Dpo) && _additionalBinaryDataProperties?.ContainsKey("dpo") != true)
            {
                writer.WritePropertyName("dpo"u8);
                writer.WriteObjectValue(Dpo, options);
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

        InternalTodoFineTuneMethod IJsonModel<InternalTodoFineTuneMethod>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalTodoFineTuneMethod JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTodoFineTuneMethod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalTodoFineTuneMethod)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalTodoFineTuneMethod(document.RootElement, options);
        }

        internal static InternalTodoFineTuneMethod DeserializeInternalTodoFineTuneMethod(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalTodoFineTuneMethodType? @type = default;
            InternalTodoFineTuneSupervisedMethod supervised = default;
            InternalTodoFineTuneDPOMethod dpo = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @type = new InternalTodoFineTuneMethodType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("supervised"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supervised = InternalTodoFineTuneSupervisedMethod.DeserializeInternalTodoFineTuneSupervisedMethod(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("dpo"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dpo = InternalTodoFineTuneDPOMethod.DeserializeInternalTodoFineTuneDPOMethod(prop.Value, options);
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalTodoFineTuneMethod(@type, supervised, dpo, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalTodoFineTuneMethod>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTodoFineTuneMethod>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalTodoFineTuneMethod)} does not support writing '{options.Format}' format.");
            }
        }

        InternalTodoFineTuneMethod IPersistableModel<InternalTodoFineTuneMethod>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalTodoFineTuneMethod PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTodoFineTuneMethod>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalTodoFineTuneMethod(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalTodoFineTuneMethod)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalTodoFineTuneMethod>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalTodoFineTuneMethod internalTodoFineTuneMethod)
        {
            if (internalTodoFineTuneMethod == null)
            {
                return null;
            }
            return BinaryContent.Create(internalTodoFineTuneMethod, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalTodoFineTuneMethod(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalTodoFineTuneMethod(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
