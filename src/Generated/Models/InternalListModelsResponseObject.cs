// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Models
{
    internal readonly partial struct InternalListModelsResponseObject : IEquatable<InternalListModelsResponseObject>
    {
        private readonly string _value;
        private const string ListValue = "list";

        public InternalListModelsResponseObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalListModelsResponseObject List { get; } = new InternalListModelsResponseObject(ListValue);

        public static bool operator ==(InternalListModelsResponseObject left, InternalListModelsResponseObject right) => left.Equals(right);

        public static bool operator !=(InternalListModelsResponseObject left, InternalListModelsResponseObject right) => !left.Equals(right);

        public static implicit operator InternalListModelsResponseObject(string value) => new InternalListModelsResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListModelsResponseObject other && Equals(other);

        public bool Equals(InternalListModelsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
