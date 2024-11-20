// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeRequestMessageItem : ConversationItem
    {
        public InternalRealtimeRequestMessageItem()
        {
            Role = new ConversationMessageRole("message");
        }

        internal InternalRealtimeRequestMessageItem(InternalRealtimeItemType type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, ConversationMessageRole role, ConversationItemStatus? status) : base(type, id, serializedAdditionalRawData)
        {
            Role = role;
            Status = status;
        }

        internal ConversationMessageRole Role { get; set; }
        public ConversationItemStatus? Status { get; set; }
    }
}