// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class ThreadMessage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ThreadMessage(string id, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageFailureDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, string assistantId, string runId, Assistants.MessageRole role, IEnumerable<MessageCreationAttachment> attachments)
        {
            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Content = new ChangeTrackingList<MessageContent>();
            AssistantId = assistantId;
            RunId = runId;
            Metadata = new ChangeTrackingDictionary<string, string>();
            Role = role;
            Attachments = attachments.ToList();
        }

        internal ThreadMessage(string id, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageFailureDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, IReadOnlyList<MessageContent> content, string assistantId, string runId, IReadOnlyDictionary<string, string> metadata, InternalMessageObjectObject @object, Assistants.MessageRole role, IReadOnlyList<MessageCreationAttachment> attachments, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Content = content;
            AssistantId = assistantId;
            RunId = runId;
            Metadata = metadata;
            this.Object = @object;
            Role = role;
            Attachments = attachments;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; }

        public DateTimeOffset CreatedAt { get; }

        public string ThreadId { get; }

        public MessageStatus Status { get; }

        public MessageFailureDetails IncompleteDetails { get; }

        public DateTimeOffset? CompletedAt { get; }

        public DateTimeOffset? IncompleteAt { get; }

        public IReadOnlyList<MessageContent> Content { get; }

        public string AssistantId { get; }

        public string RunId { get; }

        public IReadOnlyDictionary<string, string> Metadata { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
