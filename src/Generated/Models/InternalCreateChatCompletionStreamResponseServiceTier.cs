// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalCreateChatCompletionStreamResponseServiceTier : IEquatable<InternalCreateChatCompletionStreamResponseServiceTier>
    {
        private readonly string _value;
        private const string ScaleValue = "scale";
        private const string DefaultValue = "default";

        public InternalCreateChatCompletionStreamResponseServiceTier(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalCreateChatCompletionStreamResponseServiceTier Scale { get; } = new InternalCreateChatCompletionStreamResponseServiceTier(ScaleValue);

        public static InternalCreateChatCompletionStreamResponseServiceTier Default { get; } = new InternalCreateChatCompletionStreamResponseServiceTier(DefaultValue);

        public static bool operator ==(InternalCreateChatCompletionStreamResponseServiceTier left, InternalCreateChatCompletionStreamResponseServiceTier right) => left.Equals(right);

        public static bool operator !=(InternalCreateChatCompletionStreamResponseServiceTier left, InternalCreateChatCompletionStreamResponseServiceTier right) => !left.Equals(right);

        public static implicit operator InternalCreateChatCompletionStreamResponseServiceTier(string value) => new InternalCreateChatCompletionStreamResponseServiceTier(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateChatCompletionStreamResponseServiceTier other && Equals(other);

        public bool Equals(InternalCreateChatCompletionStreamResponseServiceTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
