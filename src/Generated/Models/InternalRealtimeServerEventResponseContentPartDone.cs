// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeServerEventResponseContentPartDone : ConversationUpdate
    {
        internal InternalRealtimeServerEventResponseContentPartDone(string eventId, string responseId, string itemId, int outputIndex, int contentIndex, ConversationContentPart internalContentPart) : base(eventId, RealtimeConversation.ConversationUpdateKind.ItemContentPartFinished)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
            _internalContentPart = internalContentPart;
        }

        internal InternalRealtimeServerEventResponseContentPartDone(string eventId, RealtimeConversation.ConversationUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string responseId, string itemId, int outputIndex, int contentIndex, ConversationContentPart internalContentPart) : base(eventId, kind, additionalBinaryDataProperties)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
            _internalContentPart = internalContentPart;
        }

        public string ResponseId { get; }

        public string ItemId { get; }

        public int OutputIndex { get; }

        public int ContentIndex { get; }
    }
}
