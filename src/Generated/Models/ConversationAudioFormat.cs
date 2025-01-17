// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    public readonly partial struct ConversationAudioFormat : IEquatable<ConversationAudioFormat>
    {
        private readonly string _value;
        private const string Pcm16Value = "pcm16";
        private const string G711UlawValue = "g711_ulaw";
        private const string G711AlawValue = "g711_alaw";

        public ConversationAudioFormat(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static ConversationAudioFormat Pcm16 { get; } = new ConversationAudioFormat(Pcm16Value);

        public static ConversationAudioFormat G711Ulaw { get; } = new ConversationAudioFormat(G711UlawValue);

        public static ConversationAudioFormat G711Alaw { get; } = new ConversationAudioFormat(G711AlawValue);

        public static bool operator ==(ConversationAudioFormat left, ConversationAudioFormat right) => left.Equals(right);

        public static bool operator !=(ConversationAudioFormat left, ConversationAudioFormat right) => !left.Equals(right);

        public static implicit operator ConversationAudioFormat(string value) => new ConversationAudioFormat(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationAudioFormat other && Equals(other);

        public bool Equals(ConversationAudioFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
