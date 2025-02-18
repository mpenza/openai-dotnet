// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatTokenTopLogProbabilityDetails
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ChatTokenTopLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8Bytes = utf8Bytes;
        }

        internal ChatTokenTopLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8Bytes = utf8Bytes;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Token { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
