// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.LegacyCompletions
{
    internal readonly partial struct InternalCreateCompletionResponseObject : IEquatable<InternalCreateCompletionResponseObject>
    {
        private readonly string _value;
        private const string TextCompletionValue = "text_completion";

        public InternalCreateCompletionResponseObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalCreateCompletionResponseObject TextCompletion { get; } = new InternalCreateCompletionResponseObject(TextCompletionValue);

        public static bool operator ==(InternalCreateCompletionResponseObject left, InternalCreateCompletionResponseObject right) => left.Equals(right);

        public static bool operator !=(InternalCreateCompletionResponseObject left, InternalCreateCompletionResponseObject right) => !left.Equals(right);

        public static implicit operator InternalCreateCompletionResponseObject(string value) => new InternalCreateCompletionResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateCompletionResponseObject other && Equals(other);

        public bool Equals(InternalCreateCompletionResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
