// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Moderations
{
    internal partial class InternalCreateModerationRequestInput3
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalCreateModerationRequestInput3(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
        }

        internal InternalCreateModerationRequestInput3(InternalCreateModerationRequestInput3Type @type, string text, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Type = @type;
            Text = text;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalCreateModerationRequestInput3Type Type { get; } = "text";

        public string Text { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
