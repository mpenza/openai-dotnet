// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Embeddings
{
    internal readonly partial struct InternalCreateEmbeddingRequestEncodingFormat : IEquatable<InternalCreateEmbeddingRequestEncodingFormat>
    {
        private readonly string _value;
        private const string FloatValue = "float";
        private const string Base64Value = "base64";

        public InternalCreateEmbeddingRequestEncodingFormat(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalCreateEmbeddingRequestEncodingFormat Float { get; } = new InternalCreateEmbeddingRequestEncodingFormat(FloatValue);

        public static InternalCreateEmbeddingRequestEncodingFormat Base64 { get; } = new InternalCreateEmbeddingRequestEncodingFormat(Base64Value);

        public static bool operator ==(InternalCreateEmbeddingRequestEncodingFormat left, InternalCreateEmbeddingRequestEncodingFormat right) => left.Equals(right);

        public static bool operator !=(InternalCreateEmbeddingRequestEncodingFormat left, InternalCreateEmbeddingRequestEncodingFormat right) => !left.Equals(right);

        public static implicit operator InternalCreateEmbeddingRequestEncodingFormat(string value) => new InternalCreateEmbeddingRequestEncodingFormat(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateEmbeddingRequestEncodingFormat other && Equals(other);

        public bool Equals(InternalCreateEmbeddingRequestEncodingFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
